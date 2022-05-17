using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gitproject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BasketController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Baseket get");
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            return Ok("Get All");
        }
    }
}