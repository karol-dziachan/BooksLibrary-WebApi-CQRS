using BooksLibrary.Application.Common.Interfaces;
using BooksLibrary.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Application.Features.BusinessLogic.Commands.RentBook;

public class RentBookCommandHandler : IRequestHandler<RentBookCommand, int>
{
    private readonly IBooksDbContext _context;
    private readonly IDateTime _date;

    public RentBookCommandHandler(IBooksDbContext context, IDateTime date)
    {
        _context = context;
        _date = date;
    }

    public async Task<int> Handle(RentBookCommand request, CancellationToken cancellationToken)
    {
        var book = await _context.Books
            .Where(i => i.Id == request.Id && i.StatusId == 1 && i.IsAvailable)
            .FirstOrDefaultAsync(cancellationToken);

        if (book is null)
        {
            return default;
        }

        _context.BorrowHistories.Add(new BorrowHistory()
        {
            BookId = book.Id,
            BorrowDate = _date.Now
        });
        
        book.IsAvailable = false;

        _context.SaveChangesAsync(cancellationToken);

        return book.Id;
    }
}