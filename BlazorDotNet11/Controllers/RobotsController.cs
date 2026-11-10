using Microsoft.AspNetCore.Mvc;

namespace BlazorDotNet11.Controllers
{
    [Route("robots.txt")]
    [ApiController]
    [ShortCircuit]
    public class RobotsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Content("User-agent: *\nDisallow: /", "text/plain");
        }
    }
}
