using MediatR;

namespace BooksLibrary.Application.Features.BusinessLogic.Queries.CheckLastRent;

public class CheckLastRentQuery : IRequest<CheckLastRentVm>
{
    public int Id { get; set; }
}