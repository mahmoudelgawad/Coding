using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebAPI_ASPCOREMVC_PlayGround.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        

        [HttpGet]
        public IActionResult GetTest()
        {
            if(CheckHeaders() == "invalid")
                return new UnauthorizedResult();
            
           var result =  GetCollection().Where(i => i == "d").FirstOrDefault();
            if (result == "s") 
            {
                //return new NotFoundResult();
                //return new ForbidResult();
                //return new OkObjectResult(null);
                return new BadRequestResult();
            }

            return Ok("Test OK");
        }
        private ICollection<string> GetCollection() 
        {
            return new List<string> { "", "sd" };
        }
        private bool IsValidEmail(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }
        private string CheckHeaders() 
        {
            int countryHeaders = HttpContext.Request.Headers.Where(h => h.Key == "x-header-country-code").Count();
            string countryCode= HttpContext.Request.Headers.First(h => h.Key == "sdsd").Value;
            if (string.IsNullOrEmpty(countryCode) || string.IsNullOrWhiteSpace(countryCode))
                return "invalid";
            return countryCode;
        }


        [HttpGet("message")]
        public ObjectResult TestMessage() 
        {
            string message = "Hello Wather !";
            message = "محمود أحمد";
            return StatusCode(StatusCodes.Status200OK, message);
        
        }
    }
}
