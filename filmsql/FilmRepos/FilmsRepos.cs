using filmLib;
using filmsql;
using FlmLib.DataAcces.etites;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace FlmLib.DataAcces.FilmRepos
{
    public class FilmsRepos
    {
        private readonly FilmLibDb _context;
        public FilmsRepos(FilmLibDb context) 
        { 
            _context = context;
        }
        public async Task<List<Film>> Get()
        {
            var filmEntites = await _context.Films
                .AsNoTracking()
                .ToListAsync();

            var films = filmEntites
                .Select(b => Film.Create(b.Id, b.Name, b.Genre, b.Year ).Film)
                .ToList();

            return films;
        }
   public async Task<Guid> Create(Film film)
        {
            var filmEntity = new FilmEntity
            {
                Id = film.Id,
                Name = film.Name,
                Genre = film.Genre,
                Year = film.Year,
            };

            await _context.Films.AddAsync(filmEntity);
            await _context.SaveChangesAsync();

            return filmEntity.Id;
        }

        public async Task<Guid> Update(Guid id, string name, string genre, decimal year)
        {
            await _context.Films
                .Where(b => b.Id == id)
                .ExecuteUpdateAsync(s => s
                .SetProperty(b => b.Name, b => name)
                .SetProperty(b => b.Genre, b => genre)
                .SetProperty(b => b.Year, b => year));

            return id;
        }
    }
}
