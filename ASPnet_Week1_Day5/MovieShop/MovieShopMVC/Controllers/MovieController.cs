using ApplicationCore.Entites;
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

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetMoviesByGenre(int id)
        //{
        //    //var movies = await _movieService.g;
        //    return View("Index.cshtml");
        //}
        // GET: MovieController

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var movies = await _movieService.GetMovieByIdAsync(id);
            return View(movies);
        }
        [HttpPost]
        public IActionResult  Create()
        {
            _movieService.AddAsync();
            return View("Index");
        }
        [HttpPut()]
        public  IActionResult Edit()
        {
           _movieService.UpdateAsync();
            return View("Index");
        }
        [HttpDelete]
        public IActionResult Delete() 
        {
            _movieService.DeleteAsync();
            return View("Index");
        }


        public async Task<IActionResult> TopRatedMovies()
        {
           var movies = await _movieService.GetTop30RevenueMovie();
            return View(movies);
        }
    }
}
