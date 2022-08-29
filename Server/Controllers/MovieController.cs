using Microsoft.AspNetCore.Mvc;
using MovieJournal.Server.Data;
using MovieJournal.Shared;


namespace MovieJournal.Server.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class MovieController : ControllerBase
  {
    private readonly ILogger<MovieController> _logger;
    private readonly DataContext _context;
    public MovieController(ILogger<MovieController> logger, DataContext context)
    {
      _logger = logger;
      _context = context;
    }

    //public List<Movie> Movies = new List<Movie>
    //{
    //  new Movie
    //  {
    //    Id = 0,
    //    Title = "Street Kings",
    //    Year = 2008,
    //    Genre = "Crime",
    //    Status = "Not Seen",
    //    Stars = 55,
    //    Review = "Yep"
    //  },
    //  new Movie
    //  {
    //    Id = 1,
    //    Title = "Spirited Away",
    //    Year = 2001,
    //    Genre = "Animation",
    //    Status = "Seen",
    //    Stars = 96,
    //    Review = "Yep"
    //  }
    //};

    [HttpGet]
    public async Task<ActionResult<List<Movie>>> GetMovies()
    {
      return Ok(_context.Movies);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Movie>> GetSingleMovie(int id)
    {
      var movie = _context.Movies.FirstOrDefault(x => x.Id == id);
      if (movie != null)
      {
        return Ok(movie);
      }
      return NotFound($"Sorry, no movie found with the id '{id}'");
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<List<Movie>>> UpdateMovie(Movie movie)
    {
      var old = _context.Movies.FirstOrDefault(x => x.Id == movie.Id);
      if (old != null)
      {
        _context.Entry(old).CurrentValues.SetValues(movie);
        await _context.SaveChangesAsync();
        return Ok(_context.Movies);
      }
      return NotFound($"Sorry, no movie found with the id '{movie.Id}'");
    }

    [HttpPost]
    public async Task<ActionResult<List<Movie>>> CreateMovie(Movie movie)
    {
      _context.Movies.Add(movie);
      await _context.SaveChangesAsync();

      return Ok(_context.Movies);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<Movie>>> DeleteMovie(int id)
    {
      var movie = _context.Movies.FirstOrDefault(x => x.Id == id);
      if (movie != null)
      {
        _context.Movies.Remove(movie);
        await _context.SaveChangesAsync();
        return Ok(_context.Movies);
      }
      else
      {
        return NotFound($"Sorry, no movie found with the id '{id}'");
      }
    }
  }
}
