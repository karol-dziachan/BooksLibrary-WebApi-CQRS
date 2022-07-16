using AutoMapper;
using BooksLibrary.Application.Common.Mappings;
using BooksLibrary.Application.Features.Books.Queries.GetBooks;
using BooksLibrary.Domain.Entities;
using BooksLibrary.Domain.ValueObjects;

namespace BooksLibrary.Application.Features.Authors.Queries.GetAuthors;

public class GetAuthorDto : IMapFrom<Author>
{
    public int Id { get; set; }
    
    public PersonName FullName { get; set; }
    
    public string BirthPlace { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Author, GetAuthorDto>();
    }
}