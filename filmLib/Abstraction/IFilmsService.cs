using filmLib;

namespace FilmLib.App.services
{
    public interface IFilmsService
    {
        Task<Guid> CreateFIlm(Film film);
        Task<Guid> DeleteFilm(Guid Id);
        Task<List<Film>> GetAllFilms();
        Task<Guid> UpdateFilm(Guid id, string name, string genre, decimal year);
    }
}