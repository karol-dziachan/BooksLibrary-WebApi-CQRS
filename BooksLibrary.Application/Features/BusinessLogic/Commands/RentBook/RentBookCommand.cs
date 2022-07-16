using MediatR;

namespace BooksLibrary.Application.Features.BusinessLogic.Commands.RentBook;

public class RentBookCommand : IRequest<int>
{
    public int Id { get; set; }
}