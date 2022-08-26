namespace OA.DataAccess
{
    public class ProductDetails : Product
    {
        public int StockAvailable { get; set; }
        public decimal Price { get; set; }
        public virtual Product Product { get; set; }
    }
}