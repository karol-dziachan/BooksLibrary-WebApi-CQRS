using System.Reflection.Metadata;
using BooksLibrary.Domain.Common;
using BooksLibrary.Domain.ValueObjects;

namespace BooksLibrary.Domain.Entities;

public class Author : AuditableEntity
{
    public PersonName FullName { get; set; }
    
    public DateTime DoB { get; set; }
    
    public string BirthPlace { get; set; }
    
    public ICollection<Book> Books { get; set; }
}