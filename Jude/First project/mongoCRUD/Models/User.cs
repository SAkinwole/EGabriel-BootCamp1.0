
using MongoDB.Entities;

namespace mongoCRUD.Models
{
    public class User : Entity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender 
    {
        Male = 1,
        Femaale = 2
    }
}