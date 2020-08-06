using Microsoft.EntityFrameworkCore;
using Models;
using Persistence.Database.Configuration;

namespace Persistence.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            ModelConfig(builder);
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new EmployeeConfiguration(modelBuilder.Entity<Employee>());
        }
    }
}
