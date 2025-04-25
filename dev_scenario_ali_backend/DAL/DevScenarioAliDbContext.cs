using dev_scenario_ali_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace dev_scenario_ali_backend.DAL
{
    public class DevScenarioAliDbContext : DbContext
    {
        public DevScenarioAliDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<StatusLevel> StatusLevel { get; set; }
        public DbSet<Application> Application { get; set; }
        public DbSet<Inquries> Inqury { get; set; }


    }
}
