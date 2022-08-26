using Net6MongoDb.Models;

namespace Net6MongoDb.Repository
{
    public interface IUserRepo
    {
        Task CreateUser(User user);
        Task<List<User>> GetAll();
        Task<User> Get(string id);
        Task<User> Update(string id, User user);
    }
}