using Microsoft.EntityFrameworkCore;
using TechLibrary.Domain;

namespace TechLibrary.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            // NoOp
        }

        public DbSet<Agency> Agency { get; set; }
        public DbSet<Agent> Agent { get; set; }
        public DbSet<Lead> Lead { get; set; }
        public DbSet<AgentLead> AgentLead { get; set; }
    }
}
