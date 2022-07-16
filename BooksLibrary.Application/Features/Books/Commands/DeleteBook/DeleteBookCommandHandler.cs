using BooksLibrary.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Application.Features.Books.Commands.DeleteBook;

public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, int>
{
    private readonly IBooksDbContext _context;

    public DeleteBookCommandHandler(IBooksDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
    {
        var book = await _context.Books
            .Where(i => i.Id == request.Id)
            .FirstOrDefaultAsync(cancellationToken);

        if (book is null)
        {
            return default;
        }

        _context.Books.Remove(book);
        await _context.SaveChangesAsync(cancellationToken);

        return book.Id;
    }
}