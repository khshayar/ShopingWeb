using Shop.Entities.Orders;

namespace Shop.Persistence.Ef.Orders;

public class OrderEntityMap:IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Orders");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
        builder.Property(x=>x.TotalPrice)
            .HasColumnType("decimal(18,2)")
            .IsRequired();
        builder.Property(x => x.Status)
            .IsRequired();
        builder.Property(x => x.CreatedAt)
            .IsRequired();
        builder.HasOne(x => x.User)
            .WithMany(x => x.Orders)
            .HasForeignKey(x => x.UserId);
    }
}