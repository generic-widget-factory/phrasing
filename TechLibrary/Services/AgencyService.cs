using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechLibrary.Data;
using TechLibrary.Domain;

namespace TechLibrary.Services
{
    public interface IAgencyService
    {
        Task<List<Agency>> GetAgenciesAsync();
        Task<Agency> GetAgencyByIdAsync(int agencyId);
    }
    public class AgencyService : IAgencyService
    {
        private readonly DataContext _dataContext;

        public AgencyService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Agency>> GetAgenciesAsync()
        {
            var queryable = _dataContext.Agency.AsQueryable();

            return await queryable.ToListAsync();
        }

        public async Task<Agency> GetAgencyByIdAsync(int agencyId)
        {
            return await _dataContext.Agency.SingleOrDefaultAsync(x => x.Id == agencyId);
        }
    }
}
