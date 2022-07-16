using AutoMapper;
using AutoMapper.QueryableExtensions;
using BooksLibrary.Application.Common.Interfaces;
using MediatR;

namespace BooksLibrary.Application.Features.Authors.Queries.GetAuthors;

public class GetAuthorsQueryHandler : IRequestHandler<GetAuthorsQuery, GetAuthorsVm>
{
    private readonly IBooksDbContext _context;
    private readonly IMapper _mapper;

    public GetAuthorsQueryHandler(IBooksDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public async Task<GetAuthorsVm> Handle(GetAuthorsQuery request, CancellationToken cancellationToken)
    {
        var authors = _context.Authors .Where(p => p.StatusId == 1);

        if (!authors.Any())
        {
            return default;
        }
        
        var authorsVm = new GetAuthorsVm();

        foreach (var author in authors)
        {
            var authorAdapter = _mapper.Map<GetAuthorDto>(author);
            authorsVm.AuthorDtos.Add(authorAdapter);
        }

        return authorsVm;
    }
}