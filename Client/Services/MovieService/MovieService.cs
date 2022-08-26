using MovieJournal.Shared;
using System.Net.Http.Json;

namespace MovieJournal.Client.Services.MovieService
{
  public class MovieService : IMovieService
  {
    private readonly HttpClient _http;
    public List<Movie> Movies { get; set; } = new List<Movie>();
    
    public MovieService(HttpClient http)
    {
      _http = http;
    }

    public async Task GetMovies()
    {
      var result = await _http.GetFromJsonAsync<List<Movie>>("api/movie");
      if (result != null)
      {
        Movies = result;
      }
    }

    public async Task<Movie> GetSingleMovie(int id)
    {
      var result = await _http.GetFromJsonAsync<Movie>($"api/movie/{id}");
      if (result != null)
      {
        return result;
      }
      throw new Exception("Movie not found");
    }
  }
}
