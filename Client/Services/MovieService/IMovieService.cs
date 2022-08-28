using MovieJournal.Shared;

namespace MovieJournal.Client.Services.MovieService
{
  public interface IMovieService
  {
    List<Movie> Movies { get; set; }
    Task GetMovies();
    Task<Movie> GetSingleMovie(int id);
    Task DeleteMovie(int id);
    Task CreateMovie(Movie movie);
    Task UpdateMovie(Movie movie);
  }
}
