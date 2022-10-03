using Microsoft.EntityFrameworkCore;

namespace ExceptionStoringServiceClassicWebApp.Models.DataModels.DBContext
{
    public class ServiceDBContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ServiceDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<AppInfo> AppInfos { get; set; }
        public DbSet<AppVersion> AppVersions { get; set; }
        public DbSet<ExeptionData> ExptionsDatas { get; set; }

    }
}
