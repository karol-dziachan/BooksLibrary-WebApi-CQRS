using BooksLibrary.Application.Common.Interfaces;

namespace BooksLibrary.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}