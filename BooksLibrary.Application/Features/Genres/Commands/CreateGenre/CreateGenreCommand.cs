using AutoMapper;
using BooksLibrary.Application.Common.Mappings;
using BooksLibrary.Domain.Entities;
using MediatR;

namespace BooksLibrary.Application.Features.Genres.Commands.CreateGenre;

public class CreateGenreCommand : IRequest<int>, IMapFrom<Genre>
{
    public string Name { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<CreateGenreCommand, Genre>();
    }
}