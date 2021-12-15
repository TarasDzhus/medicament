using Microsoft.EntityFrameworkCore; 

namespace BackendApp.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeInfo> EmployeeInfos { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedicamentOrderModel>()
                .HasKey(t => new { t.MedicamentId, t.OrderId });

            modelBuilder.Entity<MedicamentOrderModel>()
                .HasOne(sc => sc.Medicament)
                .WithMany(s => s.MedicamentOrders)
                .HasForeignKey(sc => sc.MedicamentId);

            modelBuilder.Entity<MedicamentOrderModel>()
                .HasOne(sc => sc.Order)
                .WithMany(c => c.MedicamentOrders)
                .HasForeignKey(sc => sc.OrderId);
        }
    }
}
