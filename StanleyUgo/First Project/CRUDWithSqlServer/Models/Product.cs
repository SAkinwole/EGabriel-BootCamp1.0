using System;
using System.Collections.Generic;

#nullable disable

namespace CRUDWithSqlServer.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
