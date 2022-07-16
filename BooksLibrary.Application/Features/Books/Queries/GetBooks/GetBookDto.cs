using AutoMapper;
using BooksLibrary.Application.Common.Mappings;
using BooksLibrary.Domain.Entities;

namespace BooksLibrary.Application.Features.Books.Queries.GetBooks;

public class GetBookDto  : IMapFrom<Book>
{
    public int Id { get; set; }
    
    public string Title { get; set; }
    
    public bool IsAvailAble { get; set; }
    
    public string PublicationCountry { get; set; }
    
    public string GenreName { get; set; }

    public string AuthorName { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Book, GetBookDto>()
            .ForMember(i => i.GenreName, opt => opt.MapFrom(i => i.Genre.Name))
            .ForMember(i => i.AuthorName, opt => opt.MapFrom(i => i.Author.FullName.FirstName + " " + i.Author.FullName.LastName));
    }
}