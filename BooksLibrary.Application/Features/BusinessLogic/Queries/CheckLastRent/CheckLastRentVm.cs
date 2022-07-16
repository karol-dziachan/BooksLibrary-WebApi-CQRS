using AutoMapper;
using BooksLibrary.Application.Common.Mappings;
using BooksLibrary.Domain.Entities;

namespace BooksLibrary.Application.Features.BusinessLogic.Queries.CheckLastRent;

public class CheckLastRentVm : IMapFrom<BorrowHistory>
{
    public int BookId { get; set; }
    
    public DateTime BorrowDate { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<BorrowHistory, CheckLastRentVm>();
    }
}