using AutoMapper;
using BooksLibrary.Application.Common.Interfaces;
using BooksLibrary.Domain.Entities;
using MediatR;

namespace BooksLibrary.Application.Features.Authors.Command.CreateAuthor;

public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand, int>
{
    public readonly IBooksDbContext _context;
    private readonly IMapper _mapper;

    public CreateAuthorCommandHandler(IBooksDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
    {
        var author = _mapper.Map<Author>(request);

        _context.Authors.Add(author);

        await _context.SaveChangesAsync(cancellationToken);

        return author.Id;
    }
}