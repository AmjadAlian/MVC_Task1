using Microsoft.EntityFrameworkCore;
using MVC_Task1.Models;

namespace MVC_Task1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Employee> employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;database=MVC_Task1;trusted_connection=true;TrustServerCertificate=true");
        }

    }
}
