using ApplicationCore.ServiceInterfaces;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllMovies()
        {
            var movies = await _movieService.GetAllMoviesAsync();
            return movies.Any() ? Ok(movies) : NotFound("No Movies Found");
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByIdMovies(int id)
        {
            var movies = await _movieService.GetMovieByIdAsync(id);
            return movies != null ? Ok(movies) : NotFound("No Movies Found");
        }
        [HttpGet]
        [Route("toprevenue")]
        public async Task<IActionResult> GetTopRevenueMovies()
        {
            var movies = await _movieService.GetTop30RevenueMovie();
            return movies.Any() ? Ok(movies) : NotFound("No Movies Found");
        }
        [HttpGet]
        [Route("toprated")]
        public async Task<IActionResult> GetTopRatedMovies()
        {
            var movies = await _movieService.GetTopRatedMovies();
            return movies.Any() ? Ok(movies) : NotFound("No Movies Found");
        }
        [HttpGet]
        [Route("genre/{genreId}")]
        public async Task<IActionResult> GetMoviesByGenre( int genreId)
        {
            
            var movies = await _movieService.GetMoviesByGenreAsync(genreId);
            return movies.Any() ? Ok(movies) : NotFound("No Movies Found");
        }
        [HttpGet]
        [Route("{id}/Reviews")]
        public async Task<IActionResult> GetMoviesReviewById(int id)
        {
            var moviesReview = await _movieService.GetMovieByIdAsync(id);
            return moviesReview != null ? Ok(moviesReview) : NotFound("No Movies Found");
        }


    }
}
