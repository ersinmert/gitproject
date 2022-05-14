using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gitproject.Controllers
{
    [Route("[controller]")]
    public class BetController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                Name = "Manchester - Real Madrid",
                Date = new DateTime(2022, 6, 20)
            });
        }

        [HttpGet("all")]
        public IActionResult GetAll()
        {
            return Ok(new[]{
                new
                {
                    Name = "Manchester - Real Madrid",
                    Date = new DateTime(2022, 6, 20)
                },
            new
            {
                Name = "Liverpool - Man City",
                Date = new DateTime(2022, 6, 23)
            }
            }.ToList());
        }
    }
}