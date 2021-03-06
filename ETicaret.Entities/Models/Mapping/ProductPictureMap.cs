using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ETicaret.Entities.Models.Mapping
{
    public class ProductPictureMap : EntityTypeConfiguration<ProductPicture>
    {
        public ProductPictureMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.PicPath)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("ProductPictures");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.PicPath).HasColumnName("PicPath");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.ProductPictures)
                .HasForeignKey(d => d.ProductID);

        }
    }
}
