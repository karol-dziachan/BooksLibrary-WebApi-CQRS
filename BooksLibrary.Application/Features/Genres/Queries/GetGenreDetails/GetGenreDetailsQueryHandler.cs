using AutoMapper;
using BooksLibrary.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Application.Features.Genres.Queries.GetGenreDetails;

public class GetGenreDetailsQueryHandler : IRequestHandler<GetGenreDetailsQuery, GetGenreDetailsVm>
{
    private readonly IBooksDbContext _context;
    private readonly IMapper _mapper;

    public GetGenreDetailsQueryHandler(IBooksDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GetGenreDetailsVm> Handle(GetGenreDetailsQuery request, CancellationToken cancellationToken)
    {
        var genre = await _context.Genres
            .Where(i => i.Id == request.Id && i.StatusId == 1)
            .FirstOrDefaultAsync(cancellationToken);

        if (genre is null)
        {
            return default;
        }

        var genreVm = _mapper.Map<GetGenreDetailsVm>(genre);

        return genreVm;
    }
}