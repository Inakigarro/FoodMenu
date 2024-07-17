using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodMenuApi.Domain;

public class ItemEntityTypeConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder.HasKey(item => item.CorrelationId);

        builder.Property(item => item.DisplayName);
        builder.Property(item => item.Description);
        builder.Property(item => item.Price);
        builder.Property(item => item.ImagePath);
    }
}
