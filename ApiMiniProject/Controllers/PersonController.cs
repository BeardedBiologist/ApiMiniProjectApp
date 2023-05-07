using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public ILogger _logger;
        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _logger.LogInformation("The person was logged as {Person}", value);
        }

    }
}
