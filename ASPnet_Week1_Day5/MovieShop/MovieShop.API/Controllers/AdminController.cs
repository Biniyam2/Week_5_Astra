using ApplicationCore.Models.Request;
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
    public class AdminController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IPurchaseService _purchaseService; 
        public AdminController(IMovieService movieService, IPurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
            _movieService = movieService;
        }
        [HttpPost]
        [Route("Movie")]
        public async Task<IActionResult> AddMovie(MovieRequest movieRequest )
        {
            var newMovie =await _movieService.AddAsync(movieRequest);
            return newMovie != null ? Ok(newMovie) : NotFound("No data enterd");
        }
        [HttpPut]
        [Route("Movie")]
        public async Task<IActionResult> EditMovie(MovieRequest movieRequest)
        {
            var editMovie = await _movieService.UpdateAsync(movieRequest);
            return editMovie != null ? Ok(editMovie) : NotFound("No data enterd");
        }
        [HttpPut]
        [Route("Purchases")]
        public async Task<IActionResult> GetPurchases()
        {
            var purchases = await _purchaseService.GetAllPurchasesAsync();
            return purchases != null ? Ok(purchases) : NotFound("No data found");
        }


    }

    
    
}
