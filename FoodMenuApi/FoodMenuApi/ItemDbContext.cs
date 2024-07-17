using FoodMenuApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace FoodMenuApi;

public class ItemDbContext : DbContext
{
    public DbSet<Item> Items { get; set; }

    public ItemDbContext()
    {
    }

    public ItemDbContext(DbContextOptions<ItemDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasDefaultSchema("Food");
        modelBuilder.ApplyConfiguration(new ItemEntityTypeConfiguration());
    }
}
