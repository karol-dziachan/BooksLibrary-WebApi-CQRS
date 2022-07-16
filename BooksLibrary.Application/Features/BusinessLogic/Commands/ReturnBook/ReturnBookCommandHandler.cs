using BooksLibrary.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Application.Features.BusinessLogic.Commands.ReturnBook;

public class ReturnBookCommandHandler : IRequestHandler<ReturnBookCommand, int>
{
    private readonly IBooksDbContext _context;
    private readonly IDateTime _date;

    public ReturnBookCommandHandler(IBooksDbContext context, IDateTime date)
    {
        _context = context;
        _date = date;
    }

    public async Task<int> Handle(ReturnBookCommand request, CancellationToken cancellationToken)
    {
        var book = await _context.Books
            .Where(i => i.Id == request.Id && i.StatusId == 1 && !i.IsAvailable)
            .FirstOrDefaultAsync(cancellationToken);
        
        if (book is null)
        {
            return default;
        }

        var borrowHistory = await _context.BorrowHistories
            .OrderByDescending(i => i.BorrowDate)
            .Where(b => b.BookId == request.Id)
            .FirstOrDefaultAsync(cancellationToken);

        if (borrowHistory is null)
        {
            return default;
        }

        book.IsAvailable = true;
        borrowHistory.ReturnDate = _date.Now;

        _context.SaveChangesAsync(cancellationToken);

        return book.Id;
    }
}