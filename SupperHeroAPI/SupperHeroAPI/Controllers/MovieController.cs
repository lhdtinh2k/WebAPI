using Microsoft.AspNetCore.Mvc;
using SupperHeroAPI.Models;
using SupperHeroAPI.Services;

namespace SupperHeroAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        [HttpGet(Name = "GetMovie")]
        public IResult Get(int id)
        {
            var movieService =  new MovieService();
            var movie = movieService.Get(id);

            if (movie is null) return Results.NotFound("Movie not found");

            return Results.Ok(movie);
        }
    }
}
