using BooksLibrary.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Persistence;

public static class Seed
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>().HasData(
            new Genre() {Id = 1, Name= "Fantasy", CreatedBy = String.Empty},
            new Genre() {Id = 2, Name= "Science fiction",  CreatedBy = String.Empty},
            new Genre() {Id = 3, Name= "Thriller",  CreatedBy = String.Empty},
            new Genre() {Id = 4, Name= "Romance", CreatedBy = String.Empty},
            new Genre() {Id = 5, Name= "Western",  CreatedBy = String.Empty}

        );
        modelBuilder.Entity<Author>(d =>
        {
            d.HasData(new Author()
            {
                Id = 1,
                BirthPlace = "Poland",
                Created = DateTime.Now,
                StatusId = 1, 
                CreatedBy = String.Empty
            });
            d.OwnsOne(d => d.FullName).HasData(new {AuthorId = 1, FirstName = "Andrzej", LastName = "Sapkowski"});
        });   
        modelBuilder.Entity<Author>(d =>
        {
            d.HasData(new Author()
            {
                Id = 2,
                BirthPlace = "Poland",
                Created = DateTime.Now,
                StatusId = 1, 
                CreatedBy = String.Empty
            });
            d.OwnsOne(d => d.FullName).HasData(new {AuthorId = 2, FirstName = "Stanisław", LastName = "Lem"});
        });  
        
        modelBuilder.Entity<Author>(d =>
        {
            d.HasData(new Author()
            {
                Id = 3,
                BirthPlace = "Poland",
                Created = DateTime.Now,
                StatusId = 1, 
                CreatedBy = String.Empty
            });
            d.OwnsOne(d => d.FullName).HasData(new {AuthorId = 3, FirstName = "Joanna", LastName = "Chmielewska"});
        });  
        
        modelBuilder.Entity<Author>(d =>
        {
            d.HasData(new Author()
            {
                Id = 4,
                BirthPlace = "Poland",
                Created = DateTime.Now,
                StatusId = 1, 
                CreatedBy = String.Empty
            });
            d.OwnsOne(d => d.FullName).HasData(new {AuthorId = 4, FirstName = "Andrzej", LastName = "Stojowski"});
        });   
        
        modelBuilder.Entity<Author>(d =>
        {
            d.HasData(new Author()
            {
                Id = 5,
                BirthPlace = "USA",
                Created = DateTime.Now,
                StatusId = 1, 
                CreatedBy = String.Empty
            });
            d.OwnsOne(d => d.FullName).HasData(new {AuthorId = 5, FirstName = "Ernest", LastName = "Haycox"});
        });

        modelBuilder.Entity<Book>().HasData(
            new Book() {Id = 1, AuthorId = 1, Title = "Wiedźmin", PublicationCountry = "Poland", GenreId = 1, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 2, AuthorId = 1, Title = "Krew elfów", PublicationCountry = "Poland",GenreId = 1,  CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 3, AuthorId = 1, Title = "Ostatnie życzenie", PublicationCountry = "Poland", GenreId = 1,  CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 4, AuthorId = 1, Title = "Sezon burz", PublicationCountry = "Poland", GenreId = 1,  CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 5, AuthorId = 1, Title = "Pani Jeziora", PublicationCountry = "Poland", GenreId = 1,  CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 6, AuthorId = 1, Title = "Czas pogardy", PublicationCountry = "Poland", GenreId = 1, CreatedBy = String.Empty, StatusId = 1},
            
            new Book() {Id = 7, AuthorId = 2, Title = "Solaris", PublicationCountry = "Poland", GenreId = 2, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 8, AuthorId = 2, Title = "Eden", PublicationCountry = "Poland", GenreId = 2, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 9, AuthorId = 2, Title = "Fiasko", PublicationCountry = "Poland", GenreId = 2, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 10, AuthorId = 2, Title = "Dzienniki gwiazdowe", PublicationCountry = "Poland", GenreId = 2, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 11, AuthorId = 2, Title = "Cyberiada", PublicationCountry = "Poland", GenreId = 2, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 12, AuthorId = 2, Title = "Bajki robotów", PublicationCountry = "Poland", GenreId = 2, CreatedBy = String.Empty, StatusId = 1},
            
            new Book() {Id = 13, AuthorId = 3, Title = "Klin", PublicationCountry = "Poland", GenreId = 3, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 14, AuthorId = 3, Title = "Lesio", PublicationCountry = "Poland", GenreId = 3, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 15, AuthorId = 3, Title = "Dzikie białko", PublicationCountry = "Poland", GenreId = 3, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 16, AuthorId = 3, Title = "Nawiedzony dom", PublicationCountry = "Poland", GenreId = 3, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 17, AuthorId = 3, Title = "Wszystko czerwone", PublicationCountry = "Poland", GenreId = 3, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 18, AuthorId = 3, Title = "Zwyczajne życie", PublicationCountry = "Poland", GenreId = 3, CreatedBy = String.Empty, StatusId = 1},
            
            new Book() {Id = 19, AuthorId = 4, Title = "Kareta", PublicationCountry = "Poland", GenreId = 4, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 20, AuthorId = 4, Title = "W ręku Boga", PublicationCountry = "Poland", GenreId = 4, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 21, AuthorId = 4, Title = "Zamek w Karpatach", PublicationCountry = "Poland", GenreId = 4, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 22, AuthorId = 4, Title = "Chłopiec na kucu", PublicationCountry = "Poland", GenreId = 4, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 23, AuthorId = 4, Title = "Carskie wrota", PublicationCountry = "Poland", GenreId = 4, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 24, AuthorId = 4, Title = "Kanonierka", PublicationCountry = "Poland", GenreId = 4, CreatedBy = String.Empty, StatusId = 1},
            
            new Book() {Id = 25, AuthorId = 5, Title = "Les Pionniers", PublicationCountry = "USA", GenreId = 5, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 26, AuthorId = 5, Title = "Bugles in the Afternoon", PublicationCountry = "USA", GenreId = 5, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 27, AuthorId = 5, Title = "Alder Gulch", PublicationCountry = "USA", GenreId = 5, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 28, AuthorId = 5, Title = "Free Grass", PublicationCountry = "USA", GenreId = 5, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 29, AuthorId = 5, Title = "Trail Town", PublicationCountry = "USA", GenreId = 5, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 30, AuthorId = 5, Title = "Trouble Shooter", PublicationCountry = "USA", GenreId = 5, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 31, AuthorId = 5, Title = "The Adventures", PublicationCountry = "USA", GenreId = 5, CreatedBy = String.Empty, StatusId = 1},
            new Book() {Id = 32, AuthorId = 5, Title = "The wild bunch", PublicationCountry = "USA", GenreId = 5, CreatedBy = String.Empty, StatusId = 1}
            
        );
    }
}