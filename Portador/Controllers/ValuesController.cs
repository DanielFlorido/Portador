using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Portador.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() {
                return Ok("HolaMundo!");
        }
    }
}
