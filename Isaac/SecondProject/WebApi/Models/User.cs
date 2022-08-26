using MongoDB.Entities;

namespace WebApi.Models
{
    public class User : Entity
    {
        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public Gender Gender { get; set; } 

        public string Email { get; set; } = default!;


    }


    public enum Gender
    {
        Male = 1,
        
        Female = 2,
    }

}
