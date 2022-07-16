using AutoMapper;
using BooksLibrary.Application.Common.Mappings;
using BooksLibrary.Domain.Entities;
using BooksLibrary.Domain.ValueObjects;
using MediatR;

namespace BooksLibrary.Application.Features.Authors.Command.CreateAuthor;

public class CreateAuthorCommand : IRequest<int>, IMapFrom<Author>
{
    public PersonName FullName { get; set; }
    
    public DateTime DoB { get; set; }
    
    public string BirthPlace { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<CreateAuthorCommand, Author>(); 
    }
}