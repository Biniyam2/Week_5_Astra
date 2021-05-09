using ApplicationCore.ServiceInterfaces;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShop.MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<IActionResult> AllPurchases()
        {
            var userPurchase = await _userService.GetAllUsersAsync();
            return View(userPurchase.Select(p => p.Purchases.Select(p => p.Movie)));
        }
        [HttpGet]
        public async Task<IActionResult> Purchases(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            return View(user.Purchases.Select(p => p.Movie).ToList());
        }
    }
}
