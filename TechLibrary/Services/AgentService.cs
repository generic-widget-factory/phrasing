using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechLibrary.Data;
using TechLibrary.Domain;

namespace TechLibrary.Services
{
    public interface IAgentService
    {
        Task<List<Agent>> GetAgentsAsync();
    }
    public class AgentService : IAgentService
    {
        private readonly DataContext _dataContext;

        public AgentService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Agent>> GetAgentsAsync()
        {
            var queryable = _dataContext.Agent.AsQueryable();

            return await queryable.ToListAsync();
        }
    }
}
