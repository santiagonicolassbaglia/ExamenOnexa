using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecaMutantes;

namespace ApiMutant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpPost]
        [Route("GetAdn")]
        public IActionResult GetMutant(IEnumerable<Adn> adn)
        {
            var asd = adn;
            if (asd != null)
            {
                return StatusCode(200);
            }
            return StatusCode(4003);
        }
    }
}
