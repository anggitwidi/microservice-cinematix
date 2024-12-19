using System.ComponentModel.DataAnnotations;

namespace FilmMicroservice.Models
{
    public class Film
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string AgeRating { get; set; } = string.Empty;

        [Url]
        public string PosterUrl { get; set; } = string.Empty;

        [Range(0, 1000)]
        public decimal TicketPrice { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
