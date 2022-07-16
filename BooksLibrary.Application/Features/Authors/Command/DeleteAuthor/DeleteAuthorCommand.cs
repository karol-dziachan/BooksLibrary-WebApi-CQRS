using MediatR;

namespace BooksLibrary.Application.Features.Authors.Command.DeleteAuthor;

public class DeleteAuthorCommand : IRequest<int>
{
    public int Id { get; set; }
}