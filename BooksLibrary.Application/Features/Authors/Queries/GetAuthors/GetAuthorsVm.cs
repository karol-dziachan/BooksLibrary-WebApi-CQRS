using BooksLibrary.Application.Features.Authors.Queries.GetAuthourDetails;
using MediatR;

namespace BooksLibrary.Application.Features.Authors.Queries.GetAuthors;

public class GetAuthorsVm : IRequest<GetAuthorDto>
{
    public GetAuthorsVm()
    {
        AuthorDtos = new List<GetAuthorDto>();
    }
    
    public ICollection<GetAuthorDto> AuthorDtos { get; set; }
}