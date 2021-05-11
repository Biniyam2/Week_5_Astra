using ApplicationCore.Entites;
using ApplicationCore.Models.Request;
using ApplicationCore.Models.Response;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShop.MVC.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<IActionResult> GetMoviesByGenre(int id)
        {
            var movie = await _movieService.GetMoviesByGenreAsync(id);
            return View("~/Views/Home/Index.cshtml", movie);
        }
        // GET: MovieController

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var movies = await _movieService.GetMovieByIdAsync(id);
            return View(movies);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(MovieRequest movieRequest)
        {
            await _movieService.AddAsync(movieRequest);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPut]
        public async Task< IActionResult> Edit(MovieRequest movieRequest)
        {
            await _movieService.UpdateAsync(movieRequest);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpDelete]
        public async Task< IActionResult> Delete(MovieRequest movieRequest)
        {
            _movieService.DeleteAsync(movieRequest);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> TopRatedMovies()
        {
            var movies = await _movieService.GetTop30RevenueMovie();
            return View(movies);
        }

    }
}
