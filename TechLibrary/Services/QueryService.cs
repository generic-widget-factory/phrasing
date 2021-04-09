using System.Collections.Generic;
using System.Threading.Tasks;
using TechLibrary.Data;
using TechLibrary.Domain;


namespace TechLibrary.Services
{

    /// <summary>
    /// Service wrapper for executing direct Sqlite queris vs. leadDB database
    /// </summary>
    public interface IQueryService
    {
        Task<List<Agency>> GetAgenciesAsync();
    }
    public class QueryService: IQueryService
    {
        private readonly IDataQuery _dataQuery;

        public QueryService(IDataQuery dataQuery)
        {
            _dataQuery = dataQuery;
        }
        public async Task<List<Agency>> GetAgenciesAsync()
        {
            var agencies = await _dataQuery.GetAgenciesAsync();

            return agencies;
        }
    }
}
