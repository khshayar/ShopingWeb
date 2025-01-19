namespace Shop.Persistence.Ef.Products;

public class ProductEntityMap:IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
        builder.Property(x => x.Name)
            .IsRequired();
        builder.Property(x => x.Description)
            .IsRequired();
        builder.Property(x => x.Price)
            .IsRequired()
            .HasColumnType("decimal(18,2)");
        builder.Property(x=>x.Stock)
            .IsRequired()
            .HasDefaultValue(0);
        builder.Property(x => x.IsActive)
            .IsRequired();
        builder.Property(x => x.CreatedAt)
            .IsRequired();
        builder.HasOne(x => x.Category)
            .WithMany(x => x.Products)
            .HasForeignKey(x => x.CategoryId);
    }
}