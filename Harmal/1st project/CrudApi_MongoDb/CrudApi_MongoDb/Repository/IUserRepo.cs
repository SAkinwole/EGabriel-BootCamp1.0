using CrudApiMongodb.Models;

namespace CrudApiMongodb.Repository
{
    public interface IUserRepo
    {
        Task CreaterUser(User user);
        Task<List<User>> GetAll();
        Task<User> GetOne(String Id);
        Task<User> Update(String Id, User user);
    }
}
