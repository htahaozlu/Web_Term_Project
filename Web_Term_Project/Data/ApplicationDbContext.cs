using Microsoft.EntityFrameworkCore;
using Web_Term_Project.Models;

namespace Web_Term_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure unique indexes
            modelBuilder.Entity<Admin>()
                .HasIndex(a => a.Email)
                .IsUnique();

            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.Email)
                .IsUnique();

            modelBuilder.Entity<Customer>()
                .HasIndex(c => c.NationalID)
                .IsUnique();

            modelBuilder.Entity<Ticket>()
                .HasIndex(t => t.PNR)
                .IsUnique();

            // Configure relationships
            modelBuilder.Entity<Flight>()
                .HasOne(f => f.DepartureLocation)
                .WithMany(l => l.DepartureFlights)
                .HasForeignKey(f => f.DepartureLocationID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Flight>()
                .HasOne(f => f.ArrivalLocation)
                .WithMany(l => l.ArrivalFlights)
                .HasForeignKey(f => f.ArrivalLocationID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
} 