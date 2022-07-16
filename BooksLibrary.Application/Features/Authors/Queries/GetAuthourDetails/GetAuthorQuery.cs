using BooksLibrary.Application.Features.Books.Queries.GetBooks;
using MediatR;

namespace BooksLibrary.Application.Features.Authors.Queries.GetAuthourDetails;

public class GetAuthorQuery : IRequest<GetAuthorVm>
{
    public int Id { get; set; }
}