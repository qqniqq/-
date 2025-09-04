using Microsoft.EntityFrameworkCore;
using TcrbPharmacy.Web.Models;

namespace TcrbPharmacy.Web.Data;

public class PharmacyDbContext : DbContext
{
    public PharmacyDbContext(DbContextOptions<PharmacyDbContext> options) : base(options) { }

    public DbSet<Medicine> Medicines => Set<Medicine>();
    public DbSet<Supplier> Suppliers => Set<Supplier>();
    public DbSet<Order> Orders => Set<Order>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Medicine>()
            .HasIndex(m => m.Name);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.Medicine)
            .WithMany(m => m.Orders)
            .HasForeignKey(o => o.MedicineId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.Supplier)
            .WithMany(s => s.Orders)
            .HasForeignKey(o => o.SupplierId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
