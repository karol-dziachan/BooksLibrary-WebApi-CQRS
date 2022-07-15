using BooksLibrary.Application.Features.Books.Queries.GetBookDetail;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksLibrary.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : BaseController
    {
        /// <summary>
        /// Get books collection
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        ///     404 - if there are no books
        ///     200 - if everything is ok
        /// </returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<BookDetailsVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetBookDetailsQuery() { BookId = id });

            return vm;
        }
    }
}
