using BooksLibrary.Domain.Common;

namespace BooksLibrary.Domain.Entities;

public class Book : AuditableEntity
{
    public string Title { get; set; }
    
    public bool IsAvailAble { get; set; }
    
    public string PublicationCountry { get; set; }
    
    public int GenreId { get; set; }
    
    public Genre Genre { get; set; }
    
    public int AuthorId { get; set; }
    
    public Author Author { get; set; }
    
    public ICollection<BorrowHistory> BorrowHistories { get; set; }
}