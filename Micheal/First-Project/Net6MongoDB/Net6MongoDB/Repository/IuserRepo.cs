using Net6MongoDB.Models;

namespace Net6MongoDB.Repository
{
    public interface IuserRepo
    {
        Task CreateUser(User user);
        Task<List<User>> GetAll();
        Task<User> GetById(string Id);
        Task<User> UpdateUser(string Id, User user);
    }
}
