using AutoMapper;
using AutoMapper.QueryableExtensions;
using BooksLibrary.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Application.Features.Books.Queries.GetBooks;

public class GetBooksQueryHandler : IRequestHandler<GetBooksQuery, GetBooksVm>
{
    private readonly IBooksDbContext _context;
    private readonly IMapper _mapper;

    public GetBooksQueryHandler(IBooksDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GetBooksVm> Handle(GetBooksQuery request, CancellationToken cancellationToken)
    {
        var books = _context.Books
            .Where(p => p.StatusId == 1)
            .Include(b => b.Author)
            .Include(b => b.Genre);

        var booksVm = new GetBooksVm();        
        
        foreach (var book in books)
        {
            var bookAdapter = _mapper.Map<GetBookDto>(book);
            booksVm.Books.Add(bookAdapter);
        }

        return booksVm;
    }
}