using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FuelCalculator.DataAccessLayer
{
    public class FuelContextFactory : IDesignTimeDbContextFactory<FuelCalculatorDbContext>
    {
        public FuelCalculatorDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("ConnectionStrings.json", true)
                .Build();

            var builder = new DbContextOptionsBuilder<FuelCalculatorDbContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return new FuelCalculatorDbContext(builder.Options);
        }
    }
}