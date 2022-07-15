using AutoMapper;
using BooksLibrary.Application.Common.Mappings;
using BooksLibrary.Domain.Entities;

namespace BooksLibrary.Application.Features.Books.Queries.GetBookDetail;

public class BookDetailsVm : IMapFrom<Book>
{
    public string Title { get; set; }
    
    public bool IsAvailAble { get; set; }
    
    public string PublicationCountry { get; set; }
    
    public string GenreName { get; set; }

    public string AuthorName { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Book, BookDetailsVm>()
            .ForMember(i => i.GenreName, opt => opt.MapFrom(i => i.Genre.Name))
            .ForMember(i => i.AuthorName, opt => opt.MapFrom(i => i.Author.FullName.FirstName));
    }
}