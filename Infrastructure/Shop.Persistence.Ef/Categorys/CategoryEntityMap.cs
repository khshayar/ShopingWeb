using Shop.Entities.Categorys;

namespace Shop.Persistence.Ef.Categorys;

public class CategoryEntityMap:IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Category");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
        builder.Property(x => x.Name)
            .IsRequired();
        builder.Property(x=>x.CreatedAt)
            .IsRequired();
    }
}