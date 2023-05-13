using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Shared.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<MobilePhone> MobilePhones { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<LocationData> LocationData { get; set; } = null!;
        public DbSet<Service> Services { get; set; } = null!;
        public DbSet<ServiceProvider> ServiceProviders { get; set; } = null!;
        public DbSet<ServiceReceiver> ServiceReceivers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database connection
            optionsBuilder.UseSqlServer("YourConnectionString");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define the relationships between entities

            modelBuilder.Entity<Service>()
                .HasOne(s => s.ServiceProvider)
                .WithMany(sp => sp.Services)
                .HasForeignKey(s => s.ServiceProviderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Service>()
                .HasOne(s => s.ServiceReceiver)
                .WithMany(sr => sr.ServicesReceived)
                .HasForeignKey(s => s.ServiceReceiverId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
