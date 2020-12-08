using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sweaj.Seriailzation.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        public PingController()
        {

        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok("Welcome to the Serialization WebAPI. This is the default start location of the project. ");
        }
    }
}
