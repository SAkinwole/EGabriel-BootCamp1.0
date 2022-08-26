using MongoDB.Entities;

namespace CrudApiMongodb.Models
{
    public enum Gender
    {
        Male = 1,
        Female = 2
    }
    public class User : Entity
    {
        public String FirstName { get; set; } = default!;
        public String LastName { get; set; } = default!;
        public Gender Gender { get; set; }
        public String Email { get; set; } = default!;
    }
    
}
