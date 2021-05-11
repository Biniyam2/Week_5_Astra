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
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Register(UserRequest userRequest)
        {
            var user =await _userService.AddAsync(userRequest);
            return CreatedAtRoute("GerUser", new { id = user.Id }, user);
        }
        [HttpGet]
        [Route("{id:int}", Name = "GetUser")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            return Ok(user);
        }
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllUsers()
        {
            var user = await _userService.GetAllUsersAsync();
            return Ok(user);
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> UserLogin(string email, string password)
        {
            var user = await _userService.ValidateUser(email, password);
            return Ok(user);
        }
    }
}
