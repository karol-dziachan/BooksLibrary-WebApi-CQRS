using MediatR;

namespace BooksLibrary.Application.Features.Books.Queries.GetBookDetail;

public class GetBookDetailsQuery : IRequest<BookDetailsVm>
{
    public int BookId { get; set; }
}