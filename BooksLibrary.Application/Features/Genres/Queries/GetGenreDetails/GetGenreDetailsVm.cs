using AutoMapper;
using BooksLibrary.Application.Common.Mappings;
using BooksLibrary.Domain.Entities;

namespace BooksLibrary.Application.Features.Genres.Queries.GetGenreDetails;

public class GetGenreDetailsVm : IMapFrom<Genre>
{
    public int Id { get; set; }
    
    public string Name { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Genre, GetGenreDetailsVm>();
    }
}