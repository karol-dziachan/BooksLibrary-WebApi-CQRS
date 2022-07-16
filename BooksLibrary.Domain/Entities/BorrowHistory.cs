using BooksLibrary.Domain.Common;

namespace BooksLibrary.Domain.Entities;

public class BorrowHistory : AuditableEntity
{
    public int BookId { get; set; }
    
    public Book Book { get; set; }
    
    public DateTime BorrowDate { get; set; }
    
    public DateTime? ReturnDate { get; set; }
}