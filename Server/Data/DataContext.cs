using Microsoft.EntityFrameworkCore;
using MovieJournal.Shared;

namespace MovieJournal.Server.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
      
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Movie>().HasData(
        new Movie
        {
          Id = 1,
          Title = "Street Kings",
          Year = 2008,
          Genre = "Crime",
          Stars = 2,
          Review = "Yep",
          Image = String.Empty,
        },
        new Movie
        {
          Id = 2,
          Title = "Spirited Away",
          Year = 2001,
          Genre = "Animation",
          Stars = 1,
          Review = "Yep",
          Image = String.Empty,
        }
      );
    }

    public DbSet<Movie> Movies { get; set; }
  }
}
