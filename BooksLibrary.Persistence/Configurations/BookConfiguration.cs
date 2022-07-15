using BooksLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksLibrary.Persistence.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Title).HasMaxLength(300).IsRequired();

        builder.Property(p => p.IsAvailAble).HasDefaultValue(true);

    }
}