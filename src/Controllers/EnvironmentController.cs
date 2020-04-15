using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Dotnet.Appsettings.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnvironmentController : ControllerBase
    {

        private readonly IConfiguration _config;

        public EnvironmentController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet, Route("value")]
        public string Get(string key)
        {
            return _config[key];
        }
    }
}
