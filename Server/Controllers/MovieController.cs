using Microsoft.AspNetCore.Mvc;
using MovieJournal.Shared;

namespace MovieJournal.Server.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class MovieController : ControllerBase
  {
    private readonly ILogger<MovieController> _logger;
    public MovieController(ILogger<MovieController> logger)
    {
      _logger = logger;
    }

    public List<Movie> Movies = new List<Movie>
    {
      new Movie
      {
        Id = 0,
        Title = "Street Kings",
        Year = 2008,
        Genre = "Crime",
        Status = "Not Seen",
        Stars = 55,
        Review = "Yep"
      },
      new Movie
      {
        Id = 1,
        Title = "Spirited Away",
        Year = 2001,
        Genre = "Animation",
        Status = "Seen",
        Stars = 96,
        Review = "Yep"
      }
    };

    [HttpGet]
    public async Task<ActionResult<List<Movie>>> GetMovies()
    {
      return Ok(Movies);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Movie>> GetSingleMovie(int id)
    {
      var movie = Movies.FirstOrDefault(x => x.Id == id);
      if (movie != null)
      {
        return Ok(movie);
      }
      return NotFound($"Sorry, no movie found with the id '{id}'");
    }
  }
}
