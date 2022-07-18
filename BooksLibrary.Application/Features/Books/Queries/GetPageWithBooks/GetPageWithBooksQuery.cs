using MediatR;

namespace BooksLibrary.Application.Features.Books.Queries.GetPageWithBooks;

public class GetPageWithBooksQuery : IRequest<GetPageWithBooksVm>
{
    public int PageNumber { get; set; }
    
    public int PageSize { get; set; }
}