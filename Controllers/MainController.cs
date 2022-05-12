using System;
using Microsoft.AspNetCore.Mvc;

namespace gitproject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController: ControllerBase{
        [HttpGet]
        public IActionResult Get(){
            return Ok("ok");
        }

        [HttpGet]
        public IActionResult GetAll(){
            return Ok("All Ok");
        }
    }
}