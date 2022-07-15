﻿using BooksLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksLibrary.Persistence.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.OwnsOne(p => p.FullName).Property(p => p.FirstName).HasColumnName("FirstName").IsRequired();
        builder.OwnsOne(p => p.FullName).Property(p => p.LastName).HasColumnName("LastName").IsRequired();
    }
}