using Shop.Entities.Coupons;

namespace Shop.Persistence.Ef.Copons;

public class CoponEntityMap:IEntityTypeConfiguration<Coupon>
{
    public void Configure(EntityTypeBuilder<Coupon> builder)
    {
        builder.ToTable("Coupons");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
        builder.Property(x => x.Code)
            .IsRequired();
        builder.Property(x => x.DiscountAmount)
            .IsRequired()
            .HasColumnType("decimal(18,2)");
        builder.Property(x=>x.ExpiryDate)
            .IsRequired();
        builder.Property(x => x.IsActive)
            .IsRequired();
    }
}