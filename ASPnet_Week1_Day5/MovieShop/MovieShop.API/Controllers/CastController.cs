﻿using Infrastructure.Services;
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
    public class CastController : ControllerBase
    {
        private readonly CastService _castService;
        public CastController(CastService castService)
        {
            _castService = castService;
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetCastById(int id) 
        {
            var cast =await _castService.GetCastByIdAsync(id);
            return cast == null ? Ok(cast) : NotFound("No Cast Found");
        }
    }
}