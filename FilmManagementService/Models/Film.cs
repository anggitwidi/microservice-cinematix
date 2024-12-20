using System;

namespace FilmMicroservice.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AgeRating { get; set; }
        public string PosterUrl { get; set; }
        public decimal TicketPrice { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
