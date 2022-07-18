using AutoMapper;
using BooksLibrary.Application.Common.Interfaces;
using MediatR;

namespace BooksLibrary.Application.Features.Books.Queries.GetPageWithBooks;

public class GetPageWithBooksQueryHandler : IRequestHandler<GetPageWithBooksQuery, GetPageWithBooksVm>
{
    private readonly IBooksDbContext _context;
    private readonly IMapper _mapper;

    public GetPageWithBooksQueryHandler(IBooksDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<GetPageWithBooksVm> Handle(GetPageWithBooksQuery request, CancellationToken cancellationToken)
    {
        var books = _context.Books.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize);

        if (books is null)
        {
            return default;
        }

        var getPageWithBooksVm = new GetPageWithBooksVm();
        
        foreach (var book in books)
        {
            var bookMap = _mapper.Map<GetPageWithBooksDto>(book);
            getPageWithBooksVm.BooksDtos.Add(bookMap);
        }

        getPageWithBooksVm.LastPageNumber = GetLastPageNumber(request.PageSize);
        getPageWithBooksVm.LastPageSize = GetLastPageSize(request.PageSize);

        return getPageWithBooksVm;
    }

    private int GetLastPageSize(int pageSize)
    {
        int lastPageSize = _context.Books.Count() % pageSize;

        return lastPageSize == 0 ? pageSize : lastPageSize;
    }

    private int GetLastPageNumber(int pageSize)
    {
        int lastPageSize = GetLastPageSize(pageSize);
        int booksCount = _context.Books.Count();

        return lastPageSize == pageSize ? booksCount / pageSize : (booksCount / pageSize) + 1;
    }
}