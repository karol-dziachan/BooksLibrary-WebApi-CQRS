using MediatR;

namespace BooksLibrary.Application.Features.Books.Commands.DeleteBook;

public class DeleteBookCommand : IRequest<int>
{
    public int Id { get; set; }
}