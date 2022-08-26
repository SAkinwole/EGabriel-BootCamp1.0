using MongoDB.Entities;

namespace SimpleWebApiWithMongoDb.Models.Users
{
    public class User : Entity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Gender Gender { get; set; } 
    }

    public enum Gender
    {
        Male = 1,
        Female = 2,
    }
}
