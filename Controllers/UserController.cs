using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gitproject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                Name = "Ersin Mert",
                Surname = "Demircan",
                Birthdate = new DateTime(1991, 1, 1)
            });
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            return Ok("GetAll");
        }

        [HttpPost]
        public IActionResult Add()
        {
            return Ok("added");
        }

        [HttpPut]
        public IActionResult Edit()
        {
            return Ok("Edited");
        }
    }
}