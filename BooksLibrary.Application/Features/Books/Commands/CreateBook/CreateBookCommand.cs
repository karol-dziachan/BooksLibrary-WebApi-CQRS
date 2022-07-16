using AutoMapper;
using BooksLibrary.Application.Common.Mappings;
using BooksLibrary.Domain.Entities;
using MediatR;

namespace BooksLibrary.Application.Features.Books.Commands;

public class CreateBookCommand : IRequest<int>, IMapFrom<Book>
{
    public string Title { get; set; }
    
    public bool IsAvailAble { get; set; }
    
    public string PublicationCountry { get; set; }
    
    public int GenreId { get; set; }
    
    public int AuthorId { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<CreateBookCommand, Book>();
    }
}
