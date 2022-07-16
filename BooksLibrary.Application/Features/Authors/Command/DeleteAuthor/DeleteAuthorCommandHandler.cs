using AutoMapper;
using BooksLibrary.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Application.Features.Authors.Command.DeleteAuthor;

public class DeleteAuthorCommandHandler : IRequestHandler<DeleteAuthorCommand, int>
{
    private readonly IBooksDbContext _context; 
    private readonly IMapper _mapper;

    public DeleteAuthorCommandHandler(IBooksDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(DeleteAuthorCommand request, CancellationToken cancellationToken)
    {
        var author = await _context.Authors
            .Where(i => i.Id == request.Id)
            .Include(p => p.FullName)
            .FirstOrDefaultAsync(cancellationToken);

        if (author is null)
        {
            return default;
        }

        _context.Authors.Remove(author);
        await _context.SaveChangesAsync(cancellationToken);

        return author.Id;
    }
}