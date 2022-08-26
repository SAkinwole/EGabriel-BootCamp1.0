using SimpleWebApiWithMongoDb.Models.Users;

namespace SimpleWebApiWithMongoDb.Data.Repository
{
    public interface IUserRepo
    {
        Task CreateUser(User user);
        Task<List<User>> GetUsers();
        Task<User> GetUser(string Id);
        Task<User> UpdateUser(string Id, User user);

    }
}
