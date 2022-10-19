using Microsoft.EntityFrameworkCore;

namespace CyberpunkVehicles.Entities
{
    public class VehicleDbContext: DbContext
    {
        public VehicleDbContext(DbContextOptions<VehicleDbContext> options)
            :base(options) {}

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Drivetrain> Drivetrains { get; set; }
        public DbSet<Body> Bodies { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>(eb =>
            {
                eb.Property(v => v.Name).HasMaxLength(25).IsRequired();
                eb.Property(v => v.Group).HasMaxLength(20).IsRequired();
                eb.Property(v => v.Description).HasMaxLength(250).IsRequired();
                eb.Property(v => v.DrivetrainId).IsRequired();
                eb.Property(v => v.BodyId).IsRequired();
                eb.Property(v => v.Weight).IsRequired();
                eb.Property(v => v.HorsePower).IsRequired();
                eb.Property(v => v.TopSpeed).IsRequired();
                eb.Property(v => v.Year).IsRequired();
            });
            
            modelBuilder.Entity<Drivetrain>()
                .Property(d => d.Type)
                .IsRequired();
            
            modelBuilder.Entity<Body>()
                .Property(b => b.Type)
                .IsRequired();
        }
    }
}