using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksLibrary.Controllers
{
    [Route("api/health")]
    [ApiController]
    public class HealthChecksController : ControllerBase
    {
        /// <summary>
        /// The endpoint should return health of the application
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/get")]
        public async Task<string> Get()
        {
            return "Healthy";
        }
    }
}
