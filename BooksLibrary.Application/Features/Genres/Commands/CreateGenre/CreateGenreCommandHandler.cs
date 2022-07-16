using AutoMapper;
using BooksLibrary.Application.Common.Interfaces;
using BooksLibrary.Domain.Entities;
using MediatR;

namespace BooksLibrary.Application.Features.Genres.Commands.CreateGenre;

public class CreateGenreCommandHandler : IRequestHandler<CreateGenreCommand, int>
{
    private readonly IBooksDbContext _context;
    private readonly IMapper _mapper;

    public CreateGenreCommandHandler(IBooksDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateGenreCommand request, CancellationToken cancellationToken)
    {
        Genre genre = _mapper.Map<Genre>(request);

        _context.Genres.Add(genre);

        await _context.SaveChangesAsync(cancellationToken);

        return genre.Id;
    }
}