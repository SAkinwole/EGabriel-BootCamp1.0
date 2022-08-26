using WebApi.Models;

namespace WebApi.Reposiotry
{
    public interface IUserRepo
    {
        Task CreateUser(User user);

        Task<List<User>> GetAll();

        Task<User> Get(string Id);

        Task<User> Update(string Id, User user);
    }
}
