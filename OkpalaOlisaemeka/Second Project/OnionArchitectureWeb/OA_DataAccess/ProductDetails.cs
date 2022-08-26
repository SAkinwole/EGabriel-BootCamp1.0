using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OA_DataAccess
{
    public class ProductDetails : BaseEntity
    {
        public int StockAvailable { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public virtual Product Product { get; set; }
        public string ProductName { get; set; }
    }
}
