using MediatR;

namespace BooksLibrary.Application.Features.Genres.Queries.GetGenreDetails;

public class GetGenreDetailsQuery : IRequest<GetGenreDetailsVm>
{
    public int Id { get; set; }
}