using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestAPIHTTPEndpointsWithoutPostman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "Hello, world!";
        }


        [HttpPost]
        public string Post([FromBody] string name)
        {
            return "Hello, " + name + "!";
        }

    }
}
