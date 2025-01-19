using Shop.Entities.Payments;

namespace Shop.Persistence.Ef.Payments;

public class PaymentEntityMap:IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.ToTable("Payments");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
        builder.Property(x => x.CreatedAt)
            .IsRequired();
        builder.Property(x=>x.PaymentStatus)
            .IsRequired();
        builder.Property(x=>x.TransactionId)
            .IsRequired();
        builder.Property(x=>x.PaymentMethod)
            .IsRequired();
        builder.HasOne(x=>x.Order)
            .WithOne(x=>x.Payment)
            .HasForeignKey<Payment>(x=>x.OrderId);
    }
}