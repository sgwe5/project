using filmLib;

namespace FlmLib.DataAcces.FilmRepos
{
    public interface IFilmsRepos
    {
        Task<Guid> Create(Film film);
        Task<List<Film>> Get();
        Task<Guid> Update(Guid id, string name, string genre, decimal year);
        Task<Guid> Delete(Guid id);
    }
}