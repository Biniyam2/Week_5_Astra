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
    public class HomeController : Controller
    {
        private readonly IMovieService _movieService;
        public HomeController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        // GET: HomeController
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var movies = await _movieService.GetAll();
            return View(movies);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Index(int id)
        {
            var movies = await _movieService.GetById(id);
            return View(movies);
        }
        [HttpPost()]
        public IActionResult Edit()
        {
             _movieService.Update();
            return View("Index");
        }
        [HttpDelete]
        public IActionResult Delete() 
        {
            _movieService.Delete();
            return View("Index");
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult TopRatedMovies()
        {
            return View();
        }
    }
}
