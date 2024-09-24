using Microsoft.AspNetCore.Mvc;

namespace iot.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        [Route("/")]
        [HttpGet]
        public IActionResult test() {
            Console.WriteLine("we have someone got us a message");
            return Ok("ok data was gotten");
        }
        [Route("/tt")]
        [HttpPost]
        public IActionResult test(object obj)
        {
            Console.WriteLine("we have someone got us a message");
            Console.WriteLine(obj);
            return Ok("ok data was gotten");
        }

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

    }
}
