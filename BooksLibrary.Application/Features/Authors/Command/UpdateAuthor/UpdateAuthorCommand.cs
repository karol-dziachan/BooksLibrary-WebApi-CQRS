using System.Text.Json.Serialization;
using AutoMapper;
using BooksLibrary.Application.Common.Mappings;
using BooksLibrary.Domain.Entities;
using BooksLibrary.Domain.ValueObjects;
using MediatR;

namespace BooksLibrary.Application.Features.Authors.Command.UpdateAuthor;

public class UpdateAuthorCommand : IMapFrom<Author>, IRequest<int>
{
    [JsonIgnore]
    public int Id { get; set; }
    
    public PersonName FullName { get; set; }
    
    public DateTime DoB { get; set; }
    
    public string BirthPlace { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<UpdateAuthorCommand, Author>();
    }
}