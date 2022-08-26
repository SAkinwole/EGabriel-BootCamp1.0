using NET6MONGODB.Models;

namespace NET6MONGODB.Repository
{
   public interface IUserRepo
   {
        Task CreateUser(User user);
        Task<List<User>> GetAll();
        Task<User> Get(string Id);
        Task<User> update(string Id, User user);
   }
}