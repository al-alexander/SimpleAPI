using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherController()
        {
            _logger = null;
            var rng = new Random();
        }
        public WeatherController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        public static string[] Summaries1 => Summaries;

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries1[rng.Next(Summaries1.Length)]
            })
            .ToArray();
        }

        [HttpGet("{argument}")]
        public ActionResult<IEnumerable<string>> Get(string argument = "test")
        {
            return new string[] { "dotnet", "playbook" };
        }

    }
}
