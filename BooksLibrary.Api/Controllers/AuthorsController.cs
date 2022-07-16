using BooksLibrary.Application.Features.Authors.Command.CreateAuthor;
using BooksLibrary.Application.Features.Authors.Command.DeleteAuthor;
using BooksLibrary.Application.Features.Authors.Command.UpdateAuthor;
using BooksLibrary.Application.Features.Authors.Queries.GetAuthors;
using BooksLibrary.Application.Features.Authors.Queries.GetAuthourDetails;
using BooksLibrary.Application.Features.Books.Queries.GetBookDetail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksLibrary.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : BaseController
    {
        /// <summary>
        /// Get author by Id
        /// </summary>
        /// <param name="id">Author identifier</param>
        /// <returns>Author</returns>
        /// <response code="200">If everything is ok</response>
        /// <response code="403">If the user is not authorization</response>
        /// <response code="404">If the book not found</response>
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<BookDetailsVm>> GetDetails(int id)
        {
            var vm = await Mediator.Send(new GetAuthorQuery() {Id = id});

            if (vm is null)
            {
                return NotFound(id);
            }

            return Ok(vm);
        }

        /// <summary>
        /// Get authors
        /// </summary>
        /// <returns>IQueryable<GetAuthorVm></returns>
        /// <response code="200">If everything is ok</response>
        /// <response code="403">If the user is not authorization</response>
        /// <response code="404">If any author not found</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetAuthorsVm>> GetAuthors()
        {
            var vm = await Mediator.Send(new GetAuthorsQuery());

            if (vm is null)
            {
                return NotFound(vm);
            }

            return Ok(vm);
        }

        /// <summary>
        /// Create author
        /// </summary>
        /// <param name="command">Author create command</param>
        /// <returns>Newly created author id</returns>
        /// <response code="200">If everything is ok</response>
        /// <response code="403">If the user is not authorization</response>
        /// <response code="400">If the request is invalid</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateAuthor(CreateAuthorCommand command)
        {
            var authorId = await Mediator.Send(command);

            if (authorId == default)
            {
                return BadRequest(authorId);
            }

            return Ok(authorId);
        }

        /// <summary>
        /// Update author
        /// </summary>
        /// <param name="command">Author update command and id</param>
        /// <returns>Updated author id</returns>
        /// <response code="200">If everything is ok</response>
        /// <response code="403">If the user is not authorization</response>
        /// <response code="404">If any author was found</response>
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateAuthor(int id, UpdateAuthorCommand command)
        {
            command.Id = id;
            var authorId = await Mediator.Send(command);

            if (authorId == default)
            {
                return NotFound(authorId);
            }

            return Ok(authorId);
        }

        /// <summary>
        /// Delete author
        /// </summary>
        /// <param name="command">Author id</param>
        /// <returns>Deleted author id</returns>
        /// <response code="200">If everything is ok</response>
        /// <response code="403">If the user is not authorization</response>
        /// <response code="404">If any author was found</response>
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteAuthor(int id)
        {
            var vm = await Mediator.Send(new DeleteAuthorCommand() {Id = id});

            if (vm == default)
            {
                return NotFound(id);
            }

            return Ok(vm);
        }
    }
}
