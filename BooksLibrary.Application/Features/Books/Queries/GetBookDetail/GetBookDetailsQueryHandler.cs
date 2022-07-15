using AutoMapper;
using BooksLibrary.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Application.Features.Books.Queries.GetBookDetail;

public class GetBookDetailsQueryHandler : IRequestHandler<GetBookDetailsQuery, BookDetailsVm>
{
    private readonly IBooksDbContext _context;
    private readonly IMapper _mapper;

    public GetBookDetailsQueryHandler(IBooksDbContext movieDbContext, IMapper mapper)
    {
        _context = movieDbContext;
        _mapper = mapper;
    }
    
    public async Task<BookDetailsVm> Handle(GetBookDetailsQuery request, CancellationToken cancellationToken)
    {
        var book = await _context.Books
            .Where(p => (p.Id == request.BookId) && (p.StatusId == 1))
            .Include(b => b.Author)
            .Include(b => b.Genre)
            .FirstOrDefaultAsync(cancellationToken);

        var bookVm = _mapper.Map<BookDetailsVm>(book);

        return bookVm;
    }
}