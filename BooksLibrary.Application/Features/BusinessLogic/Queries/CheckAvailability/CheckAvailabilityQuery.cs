using MediatR;

namespace BooksLibrary.Application.Features.BusinessLogic.Queries.CheckAvailability;

public class CheckAvailabilityQuery : IRequest<CheckAvailabilityVm>
{
    public int Id { get; set; }
}