using Microsoft.EntityFrameworkCore;
using System;

namespace RFT.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<HeatPoint> HeatPoints { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<HeatPoint>()
            .HasNoKey()  // TVFs do not have primary keys
            .ToFunction("CalculateHeatPoints");
        }
    }
}
