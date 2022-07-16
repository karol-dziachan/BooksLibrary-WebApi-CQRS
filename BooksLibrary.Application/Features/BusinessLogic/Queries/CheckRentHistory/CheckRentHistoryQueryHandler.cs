using AutoMapper;
using BooksLibrary.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Application.Features.BusinessLogic.Queries.CheckRentHistory;

public class CheckRentHistoryQueryHandler : IRequestHandler<CheckRentHistoryQuery, CheckRentHistoryVm>
{
    private readonly IBooksDbContext _context;
    private readonly IMapper _mapper;

    public CheckRentHistoryQueryHandler(IBooksDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<CheckRentHistoryVm> Handle(CheckRentHistoryQuery request, CancellationToken cancellationToken)
    {
        var book = await _context.Books
            .Where(i => i.Id == request.Id && i.StatusId == 1)
            .FirstOrDefaultAsync(cancellationToken);

        if (book is null)
        {
            return default;
        }

        var borrows =  _context.BorrowHistories;
        var borrowsVm = new CheckRentHistoryVm();

        if (borrows is null)
        {
            return default;
        }
        
        await foreach (var borrowHistory in borrows)
        {
            var borrowAdapter = _mapper.Map<CheckRentHistoryDto>(borrowHistory);
            borrowsVm.RentHistoryDtos.Add(borrowAdapter);
        }

        return borrowsVm;
    }
}