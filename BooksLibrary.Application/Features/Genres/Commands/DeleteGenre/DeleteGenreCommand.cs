using MediatR;

namespace BooksLibrary.Application.Features.Genres.Commands.DeleteGenre;

public class DeleteGenreCommand : IRequest<int>
{
    public int Id { get; set; }
}