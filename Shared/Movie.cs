using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieJournal.Shared
{
  public class Movie
  {
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int? Year { get; set; } = null;
    public string Genre { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public int? Stars { get; set; } = null;
    public string Review { get; set; } = string.Empty;
  }
}
