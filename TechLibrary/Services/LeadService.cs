using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechLibrary.Data;
using TechLibrary.Domain;

namespace TechLibrary.Services
{
    public interface ILeadService
    {
        Task<List<Lead>> GetLeadsAsync();
    }
    public class LeadService : ILeadService
    {
        private readonly DataContext _dataContext;

        public LeadService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Lead>> GetLeadsAsync()
        {
            var queryable = _dataContext.Lead.AsQueryable();

            return await queryable.ToListAsync();
        }
    }
}
