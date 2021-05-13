using ApplicationCore.ServiceInterfaces;
using Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
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
        private readonly IPurchaseService _purchaseService;
        public UserController(IUserService userService, IPurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
            _userService = userService;
        }
        [HttpGet]
        public async Task<IActionResult> AllPurchases()
        {
            var userPurchase = await _purchaseService.GetAllPurchasesAsync();
            return View(userPurchase);
        }
        [HttpGet]
       // [Authorize]
        public async Task<IActionResult> Purchases(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            return View(user.Purchases.ToList());
        }
    }
}
