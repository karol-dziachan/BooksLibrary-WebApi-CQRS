using AutoMapper;
using BooksLibrary.Application.Common.Interfaces;
using BooksLibrary.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Application.Features.Books.Commands.UpdateBook;

public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand, int>
{
    private readonly IBooksDbContext _context;
    private readonly IMapper _mapper;

    public UpdateBookCommandHandler(IBooksDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
    {
        var book =  await _context.Books
            .Where(p => (p.Id == request.Id) && (p.StatusId == 1))
            .FirstOrDefaultAsync(cancellationToken);
        
        if (book is null)
        {
            return default;
        }

        var bookVm = _mapper.Map<UpdateBookCommand, Book>(request, book); 

        _context.Books.Update(bookVm);

        await _context.SaveChangesAsync(cancellationToken);

        return book.Id;
    }
}