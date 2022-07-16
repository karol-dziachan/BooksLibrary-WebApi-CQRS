using AutoMapper;
using BooksLibrary.Application.Common.Mappings;
using BooksLibrary.Domain.Entities;

namespace BooksLibrary.Application.Features.BusinessLogic.Queries.CheckRentHistory;

public class CheckRentHistoryDto : IMapFrom<BorrowHistory>
{
    public DateTime BorrowDate { get; set; }
    
    public DateTime? ReturnDate { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<BorrowHistory, CheckRentHistoryDto>();
    }
}