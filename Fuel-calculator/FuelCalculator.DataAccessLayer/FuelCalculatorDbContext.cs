using Microsoft.EntityFrameworkCore;

namespace FuelCalculator.DataAccessLayer
{
    public class FuelCalculatorDbContext : DbContext
    {
        public FuelCalculatorDbContext(DbContextOptions<FuelCalculatorDbContext> options) : base(options) { }
    }
}
