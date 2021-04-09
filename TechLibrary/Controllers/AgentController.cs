using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TechLibrary.Services;


namespace TechLibrary.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgentController : Controller
    {
        private readonly ILogger<AgentController> _logger;
        private readonly IAgentService _agentService;

        public AgentController(ILogger<AgentController> logger, IAgentService agentService)
        {
            _logger = logger;
            _agentService = agentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogInformation("Get all agents");

            var agencies = await _agentService.GetAgentsAsync();

            return Ok(agencies);
        }
    }
}
