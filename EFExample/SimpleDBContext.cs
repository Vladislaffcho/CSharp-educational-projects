using System.Data.Entity;

namespace EFExample
{
    public class SimpleDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}