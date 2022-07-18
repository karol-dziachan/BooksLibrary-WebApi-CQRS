namespace BooksLibrary.Application.Features.Books.Queries.GetPageWithBooks;

public class GetPageWithBooksVm
{
    public GetPageWithBooksVm()
    {
        BooksDtos = new List<GetPageWithBooksDto>();
    }
    
    public ICollection<GetPageWithBooksDto> BooksDtos { get; set; }
    
    public int LastPageNumber { get; set; }
    
    public int LastPageSize { get; set; }
}