using System;
using Microsoft.AspNetCore.Mvc;

namespace gitproject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new WeatherForecast
            {
                Date = new DateTime(2022, 10, 25),
                TemperatureC = 10,
                Summary = "25 ekim 2022 hava durumu"
            });
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok("GetAll Weather");
        }

        [HttpPost]
        public IActionResult Add()
        {
            return Ok("Added!");
        }
    }
}
