using Shop.Entities.Reviews;

namespace Shop.Persistence.Ef.Reviews;

public class ReviewEntityMap: IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.ToTable("Reviews");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();
        builder.Property(x => x.UserId)
            .IsRequired();
        builder.Property(x => x.ProductId)
            .IsRequired();
        builder.Property(x => x.Rating)
            .IsRequired()
            .HasDefaultValue(0);
        builder.HasCheckConstraint
            ("CK_Reviews_Rating"
                , "[Rating] >= 0 AND [Rating] <= 5");
        builder.Property(x => x.Comment)
            .IsRequired()
            .HasMaxLength(10000);
        builder.Property(x=>x.CreatedAt)
            .IsRequired();
        builder.HasOne(x => x.User)
            .WithMany(x => x.Reviews)
            .HasForeignKey(x => x.UserId);
        builder.HasOne(x => x.Product)
            .WithMany(x => x.Reviews)
            .HasForeignKey(x => x.ProductId);
    }
}