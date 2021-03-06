using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gitproject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Ok!");
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            return Ok("GetAll executed!");
        }

        [HttpPost]
        public IActionResult Add(string name, decimal price)
        {
            //Db operations
            return Ok(new
            {
                Name = name,
                Price = price
            });
        }
    }
}