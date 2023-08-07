
using Microsoft.EntityFrameworkCore;

namespace WebApplication15.Data
{

    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // connect to postgres with connection string from app settings
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }
        
        public DbSet<Employee> Employees { get; set; }
    }
}