using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Persistence;

public class BooksDbContextFactory : DesignTimeDbContextFactoryBase<BooksDbContext>
{
    protected override BooksDbContext CreateNewInstance(DbContextOptions<BooksDbContext> options)
    {
        return new BooksDbContext(options);
    }
}