using AutoMapper;
using BooksLibrary.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Application.Features.Genres.Commands.DeleteGenre;

public class DeleteGenreCommandHandler : IRequestHandler<DeleteGenreCommand, int>
{
    private readonly IBooksDbContext _context;
    private readonly IMapper _mapper;

    public DeleteGenreCommandHandler(IBooksDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(DeleteGenreCommand request, CancellationToken cancellationToken)
    {
        var genre = await _context.Genres
            .Where(i => i.Id == request.Id && i.StatusId == 1)
            .FirstOrDefaultAsync(cancellationToken);

        if (genre is null)
        {
            return default;
        }

        _context.Genres.Remove(genre);
        _context.SaveChangesAsync(cancellationToken);

        return genre.Id;
    }
}