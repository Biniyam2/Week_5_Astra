using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MovieShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreService _genreService;
        public GenresController(IGenreService genreService)
        {
            _genreService = genreService;
        }
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllGenres()
        {
            var genres = await _genreService.GetAllGenresAsync();

            return genres.Any() ? Ok(genres) : NotFound("oops No genre found!!");
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAllGenres(int id)
        {
            var genres = await _genreService.GetGenreByIdAsync(id);

            return genres != null ? Ok(genres) : NotFound("oops No genre found!!");
        }

    }
}
