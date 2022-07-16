using MediatR;

namespace BooksLibrary.Application.Features.BusinessLogic.Commands.ReturnBook;

public class ReturnBookCommand : IRequest<int>
{
    public int Id { get; set; }
}