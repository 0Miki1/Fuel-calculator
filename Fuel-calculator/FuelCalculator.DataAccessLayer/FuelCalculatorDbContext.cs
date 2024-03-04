using FuelCalculator.Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace FuelCalculator.DataAccessLayer
{
    public class FuelCalculatorDbContext : DbContext
    {
        public FuelCalculatorDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}