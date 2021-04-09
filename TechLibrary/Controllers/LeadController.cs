using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TechLibrary.Services;

namespace TechLibrary.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LeadController : Controller
    {
        private readonly ILogger<LeadController> _logger;
        private readonly ILeadService _leadService;

        public LeadController(ILogger<LeadController> logger, ILeadService leadService)
        {
            _logger = logger;
            _leadService = leadService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogInformation("Get all leads");

            var agencies = await _leadService.GetLeadsAsync();

            return Ok(agencies);
        }
    }
}
