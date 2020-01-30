using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IndexController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult("Request processed by " + System.Environment.MachineName);
        }
    }
}
