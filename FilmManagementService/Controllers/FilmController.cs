using Microsoft.AspNetCore.Mvc;
using FilmMicroservice.Models;

namespace FilmManagementService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetFilm()
        {
            var film = new Film
            {
                Id = 1,
                Title = "Inception",
                Description = "A mind-bending thriller",
                AgeRating = "PG-13",
                PosterUrl = "https://example.com/inception.jpg",
                TicketPrice = 12.99m,
                ReleaseDate = new DateTime(2010, 7, 16)
            };

            return Ok(film);
        }
    }
}
