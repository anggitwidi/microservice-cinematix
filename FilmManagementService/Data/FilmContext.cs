using Microsoft.EntityFrameworkCore;
using FilmMicroservice.Models;

namespace FilmMicroservice.Data
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options) : base(options)
        {
        }

        public DbSet<Film> Films { get; set; }
    }
}
