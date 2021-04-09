using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TechLibrary.Services;


namespace TechLibrary.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgencyController : Controller
    {
        private readonly ILogger<AgencyController> _logger;
        private readonly IAgencyService _agencyService;
        private readonly IQueryService _queryService;

        public AgencyController(ILogger<AgencyController> logger, IAgencyService agencyService, IQueryService queryService)
        {
            _logger = logger;
            _agencyService = agencyService;
            _queryService = queryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogInformation("Get all agencies");

            var agencies = await _agencyService.GetAgenciesAsync();
            
            //  Example of calling QueryService vs. Entity Framework DataContext:
            //var qAgencies = await _queryService.GetAgenciesAsync();

            return Ok(agencies);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            _logger.LogInformation($"Get book by id {id}");

            var agency = await _agencyService.GetAgencyByIdAsync(id);

            return Ok(agency);
        }
    }
}
