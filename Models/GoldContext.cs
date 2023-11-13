using Microsoft.EntityFrameworkCore;

namespace GoldNotification.Models;

public class GoldContext : DbContext
{
    public DbSet<Gold> Golds => Set<Gold>();
    public GoldContext(DbContextOptions<GoldContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Gold>()
            .Property(g => g.Price)
            .HasColumnType("decimal(10)");

        modelBuilder.Entity<Gold>().HasData(
            new Gold { Id = 1, Standard = "24", Price = 2200 },
            new Gold { Id = 2, Standard = "21", Price = 1500 },
            new Gold { Id = 3, Standard = "18", Price = 990 }
        );
    }

}
