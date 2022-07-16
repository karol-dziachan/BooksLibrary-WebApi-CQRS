using AutoMapper;
using BooksLibrary.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Application.Features.BusinessLogic.Queries.CheckLastRent;

public class CheckLastRentQueryHandler : IRequestHandler<CheckLastRentQuery, CheckLastRentVm>
{
    private readonly IBooksDbContext _context;
    private readonly IMapper _mapper;

    public CheckLastRentQueryHandler(IBooksDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<CheckLastRentVm> Handle(CheckLastRentQuery request, CancellationToken cancellationToken)
    {
        var book = await _context.Books
            .Where(i => i.Id == request.Id && i.StatusId == 1)
            .FirstOrDefaultAsync(cancellationToken);

        if (book is null)
        {
            return default;
        }

        var lastBorrow = await _context.BorrowHistories
            .OrderByDescending(i => i.BorrowDate)
            .FirstOrDefaultAsync(cancellationToken);

        if (lastBorrow is null)
        {
            return default;
        }

        var lastRentVm = _mapper.Map<CheckLastRentVm>(lastBorrow);

        return lastRentVm;
    }
}