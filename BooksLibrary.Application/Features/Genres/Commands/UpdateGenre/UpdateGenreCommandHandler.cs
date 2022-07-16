using AutoMapper;
using BooksLibrary.Application.Common.Interfaces;
using BooksLibrary.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Application.Features.Genres.Commands.UpdateGenre;

public class UpdateGenreCommandHandler : IRequestHandler<UpdateGenreCommand, int>
{
    private readonly IBooksDbContext _context;
    private readonly IMapper _mapper;

    public UpdateGenreCommandHandler(IBooksDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public async Task<int> Handle(UpdateGenreCommand request, CancellationToken cancellationToken)
    {
        var genre = await _context.Genres
            .Where(i => i.Id == request.Id && i.StatusId == 1)
            .FirstOrDefaultAsync(cancellationToken);

        if (genre is null)
        {
            return default;
        }

        var genreVm = _mapper.Map<UpdateGenreCommand, Genre>(request, genre);

        _context.Genres.Update(genreVm);

        await _context.SaveChangesAsync(cancellationToken);

        return genre.Id;
    }
}