using AutoMapper;
using BooksLibrary.Application.Common.Interfaces;
using BooksLibrary.Application.Features.Books.Commands.UpdateBook;
using BooksLibrary.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Application.Features.Authors.Command.UpdateAuthor;

public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand, int>
{
    private readonly IBooksDbContext _context;
    private readonly IMapper _mapper;

    public UpdateAuthorCommandHandler(IBooksDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
    {
        var author = await _context.Authors
            .Where(i => i.Id == request.Id && i.StatusId == 1)
            .FirstOrDefaultAsync(cancellationToken);

        if (author is null)
        {
            return default;
        }

        var authorVm = _mapper.Map<UpdateAuthorCommand, Author>(request, author);

        _context.Authors.Update(authorVm);
        
        await _context.SaveChangesAsync(cancellationToken);

        return author.Id;
    }
}