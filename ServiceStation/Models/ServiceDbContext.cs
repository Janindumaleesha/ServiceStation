using Microsoft.EntityFrameworkCore;

namespace ServiceStation.Models
{
    public class ServiceDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleService> vehicleServices { get; set; }

        public ServiceDbContext(DbContextOptions<ServiceDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConnectionString = "Data Source=DESKTOP-I46N7EU\\SQLEXPRESS;Initial Catalog=ServiceDb;Integrated Security=True;Trust Server Certificate=True";
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
