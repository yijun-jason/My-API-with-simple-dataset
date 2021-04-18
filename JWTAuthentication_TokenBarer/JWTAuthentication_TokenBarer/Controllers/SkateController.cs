using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication_TokenBarer.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("[controller]")]
    public class SkateController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
"ExcellentField", "VeryGoodField", "NotVerygoodField", "BadField", "PrettyGoodField", "IceMeltedField", "VeryCrowdy","Maintain"
};
        private readonly ILogger<SkateController> _logger;
        public SkateController(ILogger<SkateController> logger)
        {
            _logger = logger;
        }
        [
      HttpGet]
        public IEnumerable<Skate> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Skate
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
