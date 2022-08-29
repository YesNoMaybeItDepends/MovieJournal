using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace MovieJournal.Shared
{
  public class Movie
  {
    public int Id { get; set; }
    [Required, StringLength(195, ErrorMessage = "Please use up to 195 characters")]
    public string Title { get; set; } = string.Empty;
    [Required]
    public int? Year { get; set; } = null;
    [Required]
    public string Genre { get; set; } = string.Empty;
    
    [Required, Range(0, 5, ErrorMessage = "The number should be between {1} and {2}")]
    public int Stars { get; set; }
    [Required]
    public string Review { get; set; } = string.Empty;
    [Required]
    public string Image { get; set; }
  }
}



