using BooksLibrary.Application.Common.Interfaces;
using FluentValidation;

namespace BooksLibrary.Application.Features.Books.Commands;

public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
{
    private readonly IBooksDbContext _context;

    public CreateBookCommandValidator(IBooksDbContext context)
    {
        _context = context;
        RuleFor(x => x).Must(a => _context.Authors.Any( b =>b.Id == a.AuthorId));
        RuleFor(x => x).Must(a => _context.Genres.Any( b =>b.Id == a.GenreId));
    }
}