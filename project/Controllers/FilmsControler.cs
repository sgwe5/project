using FilmLib.App.services;
using FlmLib.DataAcces.FilmRepos;
using Microsoft.AspNetCore.Mvc;
using project.Controllers.contracs;

namespace project.Controllers
{
    [ApiController]
    [Route("[Controler]")]
    public class FilmsControler : ControllerBase
    {
        private readonly IFilmsService _filmsService;

        public FilmsControler (IFilmsService filmsService)
        {
            _filmsService = filmsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<FilmsResponse>>> GetBooks()
        {
            var films = await _filmsService.GetAllFilms();

            var response = films.Select(b => new FilmsResponse(b.Id, b.Name, b.Genre, b.Year));

            return Ok(response);
        }
    }
}
