using Microsoft.AspNetCore.Mvc;
using ApiMiniProject;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiMiniProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        public ILogger _logger;
        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;
        }

        // POST api/address
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _logger.LogInformation("The person was logged as {Person}", value);
        }

    }
}