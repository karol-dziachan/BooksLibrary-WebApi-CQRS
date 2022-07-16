using AutoMapper;
using BooksLibrary.Application.Common.Interfaces;
using BooksLibrary.Application.Features.Books.Queries.GetBooks;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Application.Features.Authors.Queries.GetAuthourDetails;

public class GetAuthorQueryHandler : IRequestHandler<GetAuthorQuery, GetAuthorVm>
{
    private readonly IBooksDbContext _context;
    private readonly IMapper _mapper;

    public GetAuthorQueryHandler(IBooksDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GetAuthorVm> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
    {
        var author = await _context.Authors
            .Where(i => (i.Id == request.Id) && (i.StatusId == 1))
            .Include(i => i.Books)
            .FirstOrDefaultAsync(cancellationToken);
        
        var authorVm = _mapper.Map<GetAuthorVm>(author);
        
        return authorVm;
    }
}