using Microsoft.EntityFrameworkCore;
using Persistence.Database;

namespace Tests.Config
{
    public class ApplicationDbContextInMemory
    {
        public static ApplicationDbContext Get()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(databaseName: $"Employees.Db")
                    .Options;

            return new ApplicationDbContext(options);
        }

    }
}
