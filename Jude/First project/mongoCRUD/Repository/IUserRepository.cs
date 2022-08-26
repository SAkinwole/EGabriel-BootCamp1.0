
using mongoCRUD.Models;

namespace mongoCRUD.Repository
{
    public interface IUserRepository
    {
        Task Create(User user);
        Task<User> Get(string id);
        Task<List<User>> GetAll();
        Task<User> Update(string id, User user);
        Task Delete(string id);
    }
}