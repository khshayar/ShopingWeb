using Shop.Entities.OrderItems;

namespace Shop.Persistence.Ef.OrderItems;

public class OrderItemEntityMap:IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.ToTable("OrderItems");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
        builder.Property(x => x.Quantity)
            .HasDefaultValue(0)
            .IsRequired();
        builder.Property(x => x.Price)
            .HasDefaultValue(0)
            .HasColumnType("decimal(18,2)")
            .IsRequired();
        builder.HasOne(x => x.Order)
            .WithMany(x => x.OrderItems)
            .HasForeignKey(x => x.OrderId);
        builder.HasOne(x => x.Product)
            .WithMany(x => x.OrderItems)
            .HasForeignKey(x => x.ProductId);
    }
}