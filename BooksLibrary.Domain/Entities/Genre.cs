using BooksLibrary.Domain.Common;

namespace BooksLibrary.Domain.Entities;

public class Genre : AuditableEntity
{
    public string Name { get; set; }
    
    public ICollection<Book> Books { get; set; }
}