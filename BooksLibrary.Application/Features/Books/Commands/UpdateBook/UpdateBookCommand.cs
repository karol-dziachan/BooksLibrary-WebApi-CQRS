using System.Text.Json.Serialization;
using AutoMapper;
using BooksLibrary.Application.Common.Mappings;
using BooksLibrary.Domain.Entities;
using MediatR;
using Newtonsoft.Json;

namespace BooksLibrary.Application.Features.Books.Commands.UpdateBook;

public class UpdateBookCommand : IRequest<int>, IMapFrom<Book>
{
    [System.Text.Json.Serialization.JsonIgnore]
    public int Id { get; set; }
    
    public string Title { get; set; }
    
    public bool IsAvailAble { get; set; }
    
    public string PublicationCountry { get; set; }
    
    public int GenreId { get; set; }
    
    public int AuthorId { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<UpdateBookCommand, Book>();
    }
}