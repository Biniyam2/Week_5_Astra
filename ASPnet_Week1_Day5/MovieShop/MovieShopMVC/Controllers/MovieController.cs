using ApplicationCore.Entites;

using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
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
  
    public class MovieController : Controller
    {
        private readonly ILogger<MovieController> _logger;
        private readonly IMovieService _movieService;
        public MovieController(ILogger<MovieController> logger, IMovieService movieService)
        {
            _logger = logger;
            _movieService = movieService;
        }
        
        //[HttpGet()]
        //public ActionResult<FetchMovieResponse> GetMovies()
        //{
        //   FetchMovieRequest fetchMovieRequest = new FetchMovieRequest { };
        //    var movies = _movieService.GetMovies(fetchMovieRequest);
        //    return movies;
        //}
       
        //[HttpGet("{id}")]
        //public ActionResult<GetMovieResponse> GetMovie(int id ) 
        //{
        //    GetMovieRequest getMovieRequest = new GetMovieRequest { Id = id };
        //    var movie = _movieService.GetMovie(getMovieRequest);
        //    return movie;
        //}

        //[HttpDelete("{id}")]
        //public ActionResult<DeleteMovieResponse> Delete(int id)
        //{
        //    DeleteMovieRequest deleteMovieRequest = new DeleteMovieRequest { Id = id};
            
        //    return _movieService.Delete(deleteMovieRequest);
        //}
        //[HttpPut()]
        //public ActionResult<UpdateMovieResponse> Update(UpdateMovieRequest updateMovieRequest)
        //{
        //    //UpdateMovieRequest updateMovieRequest = new UpdateMovieRequest();
        //    return _movieService.Update(updateMovieRequest);
        //}
        //[HttpPost]
        //public ActionResult<CreateMovieResponse> Create (CreateMovieRequest createMovieRequest) 
        //{
        //    return _movieService.Insert(createMovieRequest);
        //}


       
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
