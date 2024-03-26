using FlmLib.DataAcces.etites;
using Microsoft.EntityFrameworkCore;

namespace filmsql
{
    public class FilmLibDb : DbContext
    {
        public FilmLibDb(DbContextOptions<FilmLibDb> options) : base(options) 
        {
        }
        public DbSet<FilmEntity> Films { get; set; }
    }
}
