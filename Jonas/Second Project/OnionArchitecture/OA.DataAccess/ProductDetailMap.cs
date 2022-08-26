using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OA.DataAccess
{
    public class ProductDetailMap
    {
        public ProductDetailMap(EntityTypeBuilder<ProductDetails> entityBuilder)
        {
            entityBuilder.HasKey(x => x.ProductId);
            entityBuilder.Property(x => x.StockAvailable).IsRequired();
            entityBuilder.Property(x => x.Price);
        }
    }
}