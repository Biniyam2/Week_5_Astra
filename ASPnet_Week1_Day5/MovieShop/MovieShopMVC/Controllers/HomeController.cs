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
        public async Task<IActionResult> Index()
        {
            var movies = await _movieService.GetTop30RevenueMovie();
            
            return View(movies);
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
