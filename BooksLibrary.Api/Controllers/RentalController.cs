using BooksLibrary.Application.Features.BusinessLogic.Commands.RentBook;
using BooksLibrary.Application.Features.BusinessLogic.Commands.ReturnBook;
using BooksLibrary.Application.Features.BusinessLogic.Queries.CheckAvailability;
using BooksLibrary.Application.Features.BusinessLogic.Queries.CheckLastRent;
using BooksLibrary.Application.Features.BusinessLogic.Queries.CheckRentHistory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksLibrary.Controllers
{
    [Route("api/rental")]
    [ApiController]
    public class RentalController : BaseController
    {
        [HttpPut("/rent-book/{id:int}")]
        public async Task<ActionResult> RentBook(int id)
        {
            var vm = await Mediator.Send(new RentBookCommand() {Id = id});

            if (vm == default)
            {
                return NotFound(id);
            }

            return Ok(vm);
        } 
        
        [HttpPut("/return-book/{id:int}")]
        public async Task<ActionResult> ReturnBook(int id)
        {
            var vm = await Mediator.Send(new ReturnBookCommand() {Id = id});

            if (vm == default)
            {
                return NotFound(id);
            }

            return Ok(vm);
        }

        [HttpGet("/check-availabilitity/{id:int}")]
        public async Task<ActionResult<CheckAvailabilityVm>> CheckAvailabilitity(int id)
        {
            var vm = await Mediator.Send(new CheckAvailabilityQuery() {Id = id});

            if (vm is null)
            {
                return NotFound(id);
            }

            return Ok(vm);
        }
        
        [HttpGet("/check-last-rent/{id:int}")]
        public async Task<ActionResult<CheckLastRentVm>> CheckLastRent(int id)
        {
            var vm = await Mediator.Send(new CheckLastRentQuery() {Id = id});

            if (vm is null)
            {
                return NotFound(id);
            }

            return Ok(vm);
        }  
        
        [HttpGet("/check-rent-history/{id:int}")]
        public async Task<ActionResult<CheckRentHistoryVm>> CheckRentHistory(int id)
        {
            var vm = await Mediator.Send(new CheckRentHistoryQuery() {Id = id});

            if (vm is null)
            {
                return NotFound(id);
            }

            return Ok(vm);
        }
    }
}
