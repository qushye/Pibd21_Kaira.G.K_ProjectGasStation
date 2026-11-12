using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectGasStation.Entities;

namespace ProjectGasStation.Data
{
    internal static class AppConfiguration
    {
        private const string DefaultConnectionString =
            "Host=localhost;Port=5432;Database=gas_station;Username=postgres;Password=postgres";

        private static readonly Lazy<string> ConnectionStringValue = new(() =>
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true)
                .Build();

            return configuration.GetConnectionString("GasStationDb") ?? DefaultConnectionString;
        });

        public static string ConnectionString => ConnectionStringValue.Value;
    }

    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DbSet<Fuel> Fuels => Set<Fuel>();

        public DbSet<FuelSale> FuelSales => Set<FuelSale>();

        public DbSet<FuelSupply> FuelSupplies => Set<FuelSupply>();

        public DbSet<FuelSupplyFuel> FuelSupplyFuels => Set<FuelSupplyFuel>();

        public DbSet<Seller> Sellers => Set<Seller>();

        public DbSet<Supplier> Suppliers => Set<Supplier>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(AppConfiguration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fuel>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.FuelType).HasConversion<int>();
                entity.HasMany(e => e.FuelSales)
                    .WithOne(e => e.Fuel)
                    .HasForeignKey(e => e.FuelId)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasMany(e => e.FuelSupplyFuels)
                    .WithOne(e => e.Fuel)
                    .HasForeignKey(e => e.FuelId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Seller>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.LastName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.WorkShift).HasConversion<int>();
                entity.Property(e => e.AllowedFuelTypes).HasConversion<int>();
                entity.HasMany(e => e.FuelSales)
                    .WithOne(e => e.Seller)
                    .HasForeignKey(e => e.SellerId)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasMany(e => e.FuelSupplies)
                    .WithOne(e => e.Seller)
                    .HasForeignKey(e => e.SellerId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.CompanyName).IsRequired().HasMaxLength(150);
                entity.Property(e => e.ContactPhone).IsRequired().HasMaxLength(30);
                entity.HasMany(e => e.FuelSupplies)
                    .WithOne(e => e.Supplier)
                    .HasForeignKey(e => e.SupplierId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<FuelSale>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.WorkShift).HasConversion<int>();
                entity.Property(e => e.SaleDate).HasColumnType("timestamp without time zone");
            });

            modelBuilder.Entity<FuelSupply>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.SupplyDate).HasColumnType("timestamp without time zone");
                entity.HasMany(e => e.FuelSupplyFuels)
                    .WithOne(e => e.FuelSupply)
                    .HasForeignKey(e => e.FuelSupplyId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<FuelSupplyFuel>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasIndex(e => new { e.FuelSupplyId, e.FuelId }).IsUnique();
            });
        }
    }
}
