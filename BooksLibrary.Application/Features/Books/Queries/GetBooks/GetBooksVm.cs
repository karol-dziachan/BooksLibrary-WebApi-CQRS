using BooksLibrary.Application.Common.Mappings;
using BooksLibrary.Domain.Entities;

namespace BooksLibrary.Application.Features.Books.Queries.GetBooks;

public class GetBooksVm : IMapFrom<Book>
{
    public GetBooksVm()
    {
        Books = new List<GetBookDto>();
    }
    public ICollection<GetBookDto> Books { get; set; }
}