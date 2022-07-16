namespace BooksLibrary.Application.Features.BusinessLogic.Queries.CheckRentHistory;

public class CheckRentHistoryVm
{
    public CheckRentHistoryVm()
    {
        RentHistoryDtos = new List<CheckRentHistoryDto>();
    }
    
    public ICollection<CheckRentHistoryDto> RentHistoryDtos { get; set; }
}