using Core_ProjectAPI.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_ProjectAPI.DAL.ApiContext
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-S74UGVJ;database=CoreFirstProjectApi;integrated security=true;TrustServerCertificate=True");

        }

        public DbSet<Category> Categories { get; set; }
    }
}
