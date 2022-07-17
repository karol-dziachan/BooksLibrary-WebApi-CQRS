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
        /// <summary>
        ///   Rent a book
        /// </summary>
        /// <param name="id">Book identifier</param>
        /// <returns>Book</returns>
        /// <response code="200">If everything is ok</response>
        /// <response code="403">If the user is not authorization</response>
        /// <response code="404">If the book not found</response>
        [HttpPut("/rent-book/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> RentBook(int id)
        {
            var vm = await Mediator.Send(new RentBookCommand() {Id = id});

            if (vm == default)
            {
                return NotFound(id);
            }

            return Ok(vm);
        } 
        /// <summary>
        ///   Return a book
        /// </summary>
        /// <param name="id">Book identifier</param>
        /// <returns>Book</returns>
        /// <response code="200">If everything is ok</response>
        /// <response code="403">If the user is not authorization</response>
        /// <response code="404">If the book not found</response>
        [HttpPut("/return-book/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> ReturnBook(int id)
        {
            var vm = await Mediator.Send(new ReturnBookCommand() {Id = id});

            if (vm == default)
            {
                return NotFound(id);
            }

            return Ok(vm);
        }

        /// <summary>
        ///   Check a book
        /// </summary>
        /// <param name="id">Book identifier</param>
        /// <returns>Book</returns>
        /// <response code="200">If everything is ok</response>
        /// <response code="403">If the user is not authorization</response>
        /// <response code="404">If the book not found</response>
        [HttpGet("/check-availabilitity/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CheckAvailabilityVm>> CheckAvailabilitity(int id)
        {
            var vm = await Mediator.Send(new CheckAvailabilityQuery() {Id = id});

            if (vm is null)
            {
                return NotFound(id);
            }

            return Ok(vm);
        }
        
        /// <summary>
        ///   Check book's last rent 
        /// </summary>
        /// <param name="id">Book identifier</param>
        /// <returns>Book</returns>
        /// <response code="200">If everything is ok</response>
        /// <response code="403">If the user is not authorization</response>
        /// <response code="404">If the book not found</response>
        [HttpGet("/check-last-rent/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CheckLastRentVm>> CheckLastRent(int id)
        {
            var vm = await Mediator.Send(new CheckLastRentQuery() {Id = id});

            if (vm is null)
            {
                return NotFound(id);
            }

            return Ok(vm);
        }  
        
        /// <summary>
        ///   Check book's rent history
        /// </summary>
        /// <param name="id">Book identifier</param>
        /// <returns>Book</returns>
        /// <response code="200">If everything is ok</response>
        /// <response code="403">If the user is not authorization</response>
        /// <response code="404">If the book not found</response>
        [HttpGet("/check-rent-history/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
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
