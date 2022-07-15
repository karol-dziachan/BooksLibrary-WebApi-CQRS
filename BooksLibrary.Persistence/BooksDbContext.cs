using System.Reflection;
using BooksLibrary.Application.Common.Interfaces;
using BooksLibrary.Domain.Common;
using BooksLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Persistence;

public class BooksDbContext : DbContext, IBooksDbContext
{
    private readonly IDateTime _dateTime; 
    
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BorrowHistory> BorrowHistories { get; set; }
    public DbSet<Genre> Genres { get; set; }

    public BooksDbContext(DbContextOptions<BooksDbContext> options, IDateTime dateTime) : base(options)
    {
        _dateTime = dateTime;
    }
    
    public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options)
    {
       
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.SeedData();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedBy = string.Empty;
                    entry.Entity.Created = _dateTime.Now;
                    entry.Entity.StatusId = 1;
                    break;
                case EntityState.Modified:
                    entry.Entity.ModifiedBy = String.Empty;
                    entry.Entity.Modified =  _dateTime.Now;;
                    break;
                case EntityState.Deleted:
                    entry.Entity.ModifiedBy = String.Empty;
                    entry.Entity.Modified =  _dateTime.Now;
                    entry.Entity.Inactivated =  _dateTime.Now;
                    entry.Entity.InactivatedBy = String.Empty;
                    entry.Entity.StatusId = 0;
                    entry.State = EntityState.Modified;
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}