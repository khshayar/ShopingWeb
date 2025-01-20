using Shop.Entities.Carts;

namespace Shop.Persistence.Ef.Carts;

public class CartEntityMap:IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.ToTable("Carts");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
        builder.Property(x => x.CreatedAt)
            .IsRequired();
        builder.HasOne(x=>x.User)
            .WithOne(x=>x.Cart)
            .HasForeignKey<Cart>(x=>x.UserId);
    }
}