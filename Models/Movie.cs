using System.ComponentModel.DataAnnotations;

namespace Movie.Models
{
    public class MovieItem
    {
       // [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public int Rating { get; set; }
        public decimal Price { get; set; }
    }
}
