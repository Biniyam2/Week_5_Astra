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
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IReviewService _reviewService;
        private readonly IFavoriteService _favoriteService;
        private readonly IPurchaseService _purchaseService;
        private readonly ICurrentUserService _currentUserService;
        public UserController(IUserService userService, IReviewService reviewService, IFavoriteService favoriteService ,ICurrentUserService currentUserService, IPurchaseService purchaseService)
        {
            _userService = userService;
            _reviewService = reviewService;
            _purchaseService = purchaseService;
            _favoriteService = favoriteService;
            _currentUserService = currentUserService;
        }
        //******************************* Create ************************************************ 
        [HttpPost]
        [Route("purchases")]
        public async Task<IActionResult> BuyMovie(PurchaseRequest purchaseRequest)
        {
            var purchase = await _purchaseService.AddAsync(purchaseRequest);
            return purchase != null ? Ok(purchase) : NotFound($"No user found");
        }
        [HttpPost]
        [Route("favorite")]
        public async Task<IActionResult> AddFavorite(FavoriteRequest favoriteRequest)
        {
            var fav = await _favoriteService.AddAsync(favoriteRequest); ;
            return fav != null ? Ok(fav) : NotFound($"No user found");
        }
        [HttpPost]
        [Route("review")]
        public async Task<IActionResult> AddReview(ReviewRequest reviewRequest)
        {
            var rev = await _reviewService.AddAsync(reviewRequest);
            return rev != null ? Ok(rev) : NotFound($"No user found");
        }
        //******************************* Edit   ************************************************ 
        [HttpPut]
        [Route("review")]
        public async Task<IActionResult> EditReview(ReviewRequest reviewRequest)
        {
            var rev =await _reviewService.UpdateAsync(reviewRequest);
            return rev != null ? Ok(rev) : NotFound($"No revew found");
        }
        //******************************* Delete    ************************************************
        [HttpDelete]
        [Route("review")]
        public IActionResult DeleteUser(UserRequest userRequest)
        {
             _userService.DeleteAsync(userRequest);
            return Created("","");
        }

        //******************************* Get    ************************************************

        [HttpGet]
        [Route("{id}/purchases")]
        public async Task<IActionResult> UserPurchase(int id)
        {
            var user =await _userService.GetUserByIdAsync(id);
            return user != null ? Ok(user.Purchases) : NotFound($"No user found by the given Id = {id}");
        }
        [HttpGet]
        [Route("{id}/favorites")]
        public async Task<IActionResult> UserFavorites(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            return user != null ? Ok(user.Favorites) : NotFound($"No user found by the given Id = {id}");
        }
        [HttpGet]
        [Route("{id}/reviews")]
        public async Task<IActionResult> UserReviews(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
           
            return user != null ? Ok(user.Reviews) : NotFound($"No user found by the given Id = {id}");
        }


    }
}
