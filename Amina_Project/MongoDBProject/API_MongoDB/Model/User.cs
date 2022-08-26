using MongoDB.Entities;

namespace API_MongoDB.Model
{
    public class User: Entity

    {
        public string? FirstName { get; set; } = default;
        public string? LastName { get; set; } = default;  
        public string? Email { get; set; } = default;
        public Gender Gender { get; set; } 
       
    }
    public enum Gender 
    { 
        Female = 1,
        Male = 2
    }
}
