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
      );
    }

    public DbSet<Movie> Movies { get; set; }
  }
}
