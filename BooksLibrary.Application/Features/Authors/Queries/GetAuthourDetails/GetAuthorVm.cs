using AutoMapper;
using BooksLibrary.Application.Common.Mappings;
using BooksLibrary.Domain.Entities;
using BooksLibrary.Domain.ValueObjects;

namespace BooksLibrary.Application.Features.Authors.Queries.GetAuthourDetails;

public class GetAuthorVm : IMapFrom<Author>
{
    public PersonName FullName { get; set; }
    
    public DateTime DoB { get; set; }
    
    public string BirthPlace { get; set; }
    
    public ICollection<string> BooksTitles { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Author, GetAuthorVm>()
            .ForMember(i => i.FullName, opt => opt.MapFrom(i => i.FullName))
            .ForMember(i => i.DoB, opt => opt.MapFrom(i => i.DoB))
            .ForMember(i => i.BirthPlace, opt => opt.MapFrom(i => i.BirthPlace))
            .ForMember(i => i.BooksTitles, opt => 
                    opt.MapFrom(i => i.Books.Select(x => x.Title)));
    }
}