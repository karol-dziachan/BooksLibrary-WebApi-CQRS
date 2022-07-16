using AutoMapper;
using BooksLibrary.Application.Common.Interfaces;
using MediatR;

namespace BooksLibrary.Application.Features.Genres.Queries.GetGenres;

public class GetGenresQueryHandler : IRequestHandler<GetGenresQuery, GetGenresVm>
{
    private readonly IBooksDbContext _context;
    private readonly IMapper _mapper;

    public GetGenresQueryHandler(IBooksDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GetGenresVm> Handle(GetGenresQuery request, CancellationToken cancellationToken)
    {
        var genres = _context.Genres
            .Where(i => i.StatusId == 1);

        if (genres is null || !genres.Any())
        {
            return default;
        }
        
        var genreVm = new GetGenresVm(); 
        
        foreach (var genre in genres)
        {
            var genreAdapter = _mapper.Map<GetGenreDto>(genre);
            genreVm.GenreDtos.Add(genreAdapter);
        }

        return genreVm;
    }
}