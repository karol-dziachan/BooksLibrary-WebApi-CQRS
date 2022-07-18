using BooksLibrary.Application.Features.Books.Commands;
using BooksLibrary.Application.Features.Books.Commands.DeleteBook;
using BooksLibrary.Application.Features.Books.Commands.UpdateBook;
using BooksLibrary.Application.Features.Books.Queries.GetBookDetail;
using BooksLibrary.Application.Features.Books.Queries.GetBooks;
using BooksLibrary.Application.Features.Books.Queries.GetPageWithBooks;
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
        ///   Get page with books
        /// </summary>
        /// <param name="pageNumber">Current page number</param>
        /// <param name="pageSize">Current page size</param>
        /// <returns>Book</returns>
        /// <response code="200">If everything is ok</response>
        /// <response code="403">If the user is not authorization</response>
        /// <response code="404">If the book not found</response>
        [HttpGet("/book-page")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<BookDetailsVm>> GetPageWithBooks(int pageNumber, int pageSize)
        {
            var vm = await Mediator.Send(new GetPageWithBooksQuery() { PageSize = pageSize, PageNumber = pageNumber});

            if (!vm.BooksDtos.Any())
            {
                return NotFound(vm);
            }

            return Ok(vm);
        }
        
        /// <summary>
        ///   Get book by Id
        /// </summary>
        /// <param name="id">Book identifier</param>
        /// <returns>Book</returns>
        /// <response code="200">If everything is ok</response>
        /// <response code="403">If the user is not authorization</response>
        /// <response code="404">If the book not found</response>
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<BookDetailsVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetBookDetailsQuery() { BookId = id });

            if (vm is null)
            {
                return NotFound(id);
            }

            return Ok(vm);
        }

        /// <summary>
        ///  Get books collection
        /// </summary>
        /// <returns>ICollection<GetBookDto></returns>
        /// <response code="200">If everything is ok</response>
        /// <response code="403">If the user is not authorization</response>
        /// <response code="404">If the any book not found</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<BookDetailsVm>> GetBooks()
        {
            var vm = await Mediator.Send(new GetBooksQuery());

            if (vm is null)
            {
                return NotFound(vm);
            }

            return Ok(vm);
        }

        /// <summary>
        ///  Created new book
        /// </summary>
        /// <param name="command">New book</param>
        /// <returns>A newly created book id</returns>
        /// <response code="200">If the book was created</response>
        /// <response code="403">If the request is invalid</response>
        /// <response code="403">If the user is not authorization</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateBook(CreateBookCommand book)
        {
            var vm = await Mediator.Send(book);

            if (vm == default)
            {
                return BadRequest(vm);
            }

            return Ok(vm);
        }
        
        /// <summary>
        ///  Update the book
        /// </summary>
        /// <param name="command">Update book</param>
        /// <returns>A updated book command id</returns>
        /// <response code="200">If everything is ok</response>
        /// <response code="403">If the user is not authorization</response>
        /// <response code="404">If the book not found</response>
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateBook(int id, UpdateBookCommand book)
        {
            book.Id = id;
            var updId = await Mediator.Send(book);

            if (updId != id)
            {
                return NotFound(id);
            }

            return Ok(book);
        }

        /// <summary>
        ///  Delete the book
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>A deleted book id</returns>
        /// <response code="200">If everything is ok</response>
        /// <response code="403">If the user is not authorization</response>
        /// <response code="404">If the book not found</response>
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteBook(int id)
        {
            var updId = await Mediator.Send(new DeleteBookCommand() {Id = id});

            if (updId == default)
            {
                return NotFound(id);
            }

            return Ok(updId);
        }


    }
}
