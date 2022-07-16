using MediatR;

namespace BooksLibrary.Application.Features.BusinessLogic.Queries.CheckRentHistory;

public class CheckRentHistoryQuery : IRequest<CheckRentHistoryVm>
{
    public int Id { get; set; }
}