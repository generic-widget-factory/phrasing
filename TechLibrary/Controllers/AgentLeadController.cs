using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TechLibrary.Services;

namespace TechLibrary.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgentLeadController : Controller
    {
        private readonly ILogger<AgentLeadController> _logger;
        private readonly IAgentLeadService _agentLeadService;

        public AgentLeadController(ILogger<AgentLeadController> logger, IAgentLeadService agentLeadService)
        {
            _logger = logger;
            _agentLeadService = agentLeadService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogInformation("Get all agent leads");

            var agencies = await _agentLeadService.GetAgentLeadsAsync();

            return Ok(agencies);
        }
    }
}
