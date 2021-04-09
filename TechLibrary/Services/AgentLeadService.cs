using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechLibrary.Data;
using TechLibrary.Domain;

namespace TechLibrary.Services
{
    public interface IAgentLeadService
    {
        Task<List<AgentLead>> GetAgentLeadsAsync();
    }
    public class AgentLeadService : IAgentLeadService
    {
        private readonly DataContext _dataContext;

        public AgentLeadService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<AgentLead>> GetAgentLeadsAsync()
        {
            var queryable = _dataContext.AgentLead.AsQueryable();

            return await queryable.ToListAsync();
        }
    }
}