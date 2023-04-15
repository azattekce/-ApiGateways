using Microsoft.AspNetCore.Mvc;

namespace Azat.ApiGateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AzattekceController : ControllerBase
    {
        private static readonly string[] families = new[]
        {
        "azat", "ozge", "demir","zahir","hazal","zeynep","abdullah"
        };

        private static readonly string[] teams = new[]
       {
        "azat", "aykut", "erhan","baþar","remzi","zeynep","tuðçe"
        };


        private readonly ILogger<AzattekceController> _logger;

        public AzattekceController(ILogger<AzattekceController> logger)
        {
            _logger = logger;
        }

        [HttpGet("family")]
        public IEnumerable<WeatherForecast> GetFamilies()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = families[Random.Shared.Next(families.Length)]
            })
            .ToArray();
        }


        [HttpGet("team")]
        public IEnumerable<WeatherForecast> GetTeams()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = teams[Random.Shared.Next(teams.Length)]
            })
            .ToArray();
        }
    }
}