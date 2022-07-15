using BooksLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Application.Common.Interfaces;

public interface IBooksDbContext
{
    DbSet<Author> Authors { get; set; }
    DbSet<Book> Books { get; set; }
    DbSet<BorrowHistory> BorrowHistories { get; set; }
    DbSet<Genre> Genres { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
}