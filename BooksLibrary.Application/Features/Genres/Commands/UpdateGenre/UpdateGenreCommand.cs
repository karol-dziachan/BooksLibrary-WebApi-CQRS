using System.Text.Json.Serialization;
using AutoMapper;
using BooksLibrary.Application.Common.Mappings;
using BooksLibrary.Domain.Entities;
using MediatR;

namespace BooksLibrary.Application.Features.Genres.Commands.UpdateGenre;

public class UpdateGenreCommand : IRequest<int>, IMapFrom<Genre>
{
    [JsonIgnore]
    public int Id { get; set; }
    
    public string Name{ get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<UpdateGenreCommand, Genre>();
    }
}