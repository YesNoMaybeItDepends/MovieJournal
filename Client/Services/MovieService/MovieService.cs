using Microsoft.AspNetCore.Components;
using MovieJournal.Shared;
using System.Net.Http.Json;

namespace MovieJournal.Client.Services.MovieService
{
  public class MovieService : IMovieService
  {
    private readonly HttpClient _http;
    private readonly NavigationManager _navigationManager;
    public List<Movie> Movies { get; set; } = new List<Movie>();
    
    public MovieService(HttpClient http, NavigationManager navigationManager)
    {
      _http = http;
      _navigationManager = navigationManager;
    }

    public async Task GetMovies()
    {
      if (Movies.Count == 0)
      {
        var result = await _http.GetFromJsonAsync<List<Movie>>("api/movie");
        if (result != null)
        {
          Movies = result;
        }
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

    public async Task CreateMovie(Movie movie)
    {
      movie.Id = Movies.Count + 1;
      Movies.Add(movie);
    }

    public async Task UpdateMovie(Movie movie)
    {
      var result = await _http.PutAsJsonAsync($"api/movie/{movie.Id}", movie);
      SetMovies(result);
    }

    public async Task SetMovies(HttpResponseMessage result)
    {
      var response = await result.Content.ReadFromJsonAsync<List<Movie>>();
      Movies = response;
      _navigationManager.NavigateTo("movies");
    }

    public Task DeleteMovie(int id)
    {
      throw new NotImplementedException("AAAAAAAAAA");
    }
  }
}
