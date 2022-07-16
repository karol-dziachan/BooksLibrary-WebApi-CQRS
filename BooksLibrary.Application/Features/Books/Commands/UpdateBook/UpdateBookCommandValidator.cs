using BooksLibrary.Application.Common.Interfaces;
using FluentValidation;

namespace BooksLibrary.Application.Features.Books.Commands.UpdateBook;

public class UpdateBookCommandValidator: AbstractValidator<UpdateBookCommand>
{
    private readonly IBooksDbContext _context; 
    
    public UpdateBookCommandValidator(IBooksDbContext context)
    {
        _context = context;
        RuleFor(x => x).Must(a => _context.Authors.Any( b =>b.Id == a.AuthorId));
        RuleFor(x => x).Must(a => _context.Genres.Any( b =>b.Id == a.GenreId));
    }
}