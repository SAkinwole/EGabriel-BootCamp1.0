#nullable disable
using MongoDB.Entities;

namespace CRUDWithMongoDB.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}
