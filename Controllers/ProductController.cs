using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace gitproject.Controllers
{
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new {
                Name = "Iphone 12",
                Description = "Cep Teefonu"
            });
        }
    }
}