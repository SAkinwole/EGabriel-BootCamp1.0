using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OA.DataAccess
{
    public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasKey(product => product.ProductId);
            entityBuilder.HasOne(p => p.ProductDetails).WithOne(p => p.Product)
                .HasForeignKey<ProductDetails>(x => x.ProductId);
        }
    }
}