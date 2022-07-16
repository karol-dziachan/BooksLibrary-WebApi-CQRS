using BooksLibrary.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Application.Features.BusinessLogic.Queries.CheckAvailability;

public class CheckAvailabilityQueryHandler : IRequestHandler<CheckAvailabilityQuery, CheckAvailabilityVm>
{
    private readonly IBooksDbContext _context;

    public CheckAvailabilityQueryHandler(IBooksDbContext context)
    {
        _context = context;
    }

    public async Task<CheckAvailabilityVm> Handle(CheckAvailabilityQuery request, CancellationToken cancellationToken)
    {
        var book = await _context.Books
            .Where(i => i.Id == request.Id && i.StatusId == 1)
            .FirstOrDefaultAsync(cancellationToken);

        if (book is null)
        {
            return default;
        }

        CheckAvailabilityVm bookVm = new()
        {
            IsAvailable = book.IsAvailable
        };

        return bookVm;
    }
}