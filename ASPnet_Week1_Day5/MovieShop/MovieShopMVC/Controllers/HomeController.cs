﻿using ApplicationCore.Models.Response;
using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieShopMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShopMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMovieService _movieService;
        public HomeController(ILogger<HomeController> logger, IMovieService movieService)
        {
            _logger = logger;
            _movieService = movieService;
        }
        [HttpGet]
        public IActionResult Index()
        {
           // var movies = _movieService.GetTopRevenueMovies();
            return View(/*movies*/);
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
