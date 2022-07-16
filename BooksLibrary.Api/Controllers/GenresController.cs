using BooksLibrary.Application.Features.Genres.Commands.CreateGenre;
using BooksLibrary.Application.Features.Genres.Commands.DeleteGenre;
using BooksLibrary.Application.Features.Genres.Commands.UpdateGenre;
using BooksLibrary.Application.Features.Genres.Queries.GetGenreDetails;
using BooksLibrary.Application.Features.Genres.Queries.GetGenres;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksLibrary.Controllers
{
    [Route("api/genres")]
    [ApiController]
    public class GenresController : BaseController
    {
        /// <summary>
        ///   Get genre by Id
        /// </summary>
        /// <param name="id">Genre identifier</param>
        /// <returns>Genre</returns>
        /// <response code="200">If everything is ok</response>
        /// <response code="403">If the user is not authorization</response>
        /// <response code="404">If the genre not found</response>
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetGenresVm>> GetGenre(int id)
        {
            var vm = await Mediator.Send(new GetGenreDetailsQuery(){Id = id});

            if (vm is null)
            {
                return NotFound(id);
            }

            return Ok(vm);
        }

        /// <summary>
        ///   Get authors
        /// </summary>
        /// <returns>IQueryable<GetAuthorVm></returns>
        /// <response code="200">If everything is ok</response>
        /// <response code="403">If the user is not authorization</response>
        /// <response code="404">If any author not found</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GetGenresVm>> GetGenres()
        {
            var vm = await Mediator.Send(new GetGenresQuery());

            if (vm is null)
            {
                return NotFound(vm);
            }

            return Ok(vm);
        }

        /// <summary>
        ///  Created new genre
        /// </summary>
        /// <param name="command">New genre</param>
        /// <returns>A newly created genre id</returns>
        /// <response code="200">If the genre was created</response>
        /// <response code="400">If the request is invalid</response>
        /// <response code="403">If the user is not authorization</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Create(CreateGenreCommand command)
        {
            var genreId = await Mediator.Send(command);

            if (genreId == default)
            {
                return BadRequest(genreId);
            }

            return Ok(genreId);
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
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Update(int id, UpdateGenreCommand command)
        {
            command.Id = id;
            var genreId = await Mediator.Send(command);

            if (genreId == default)
            {
                return NotFound(genreId);
            }

            return Ok(genreId);
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
        public async Task<ActionResult> Delete(int id)
        {
            var genreId = await Mediator.Send(new DeleteGenreCommand() {Id = id});

            if (genreId == default)
            {
                return NotFound(id);
            }

            return Ok(genreId);
        }
    }
}
