namespace BooksLibrary.Application.Features.Genres.Queries.GetGenres;

public class GetGenresVm
{
    public GetGenresVm()
    {
        GenreDtos = new List<GetGenreDto>();
    }
    public ICollection<GetGenreDto> GenreDtos { get; set; }
}