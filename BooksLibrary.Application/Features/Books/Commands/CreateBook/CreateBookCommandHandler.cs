using System.Diagnostics.SymbolStore;
using AutoMapper;
using BooksLibrary.Application.Common.Interfaces;
using BooksLibrary.Domain.Entities;
using MediatR;

namespace BooksLibrary.Application.Features.Books.Commands;

public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, int>
{
    private readonly IBooksDbContext _context;
    private readonly IMapper _mapper;

    public CreateBookCommandHandler(IBooksDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateBookCommand request, CancellationToken cancellationToken)
    {
        Book book = _mapper.Map<Book>(request);

        _context.Books.Add(book);

        await _context.SaveChangesAsync(cancellationToken);

        return book.Id;
    }

  
}

