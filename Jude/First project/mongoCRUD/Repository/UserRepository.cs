

using mongoCRUD.Models;
using MongoDB.Entities;

namespace mongoCRUD.Repository
{
    public class UserRepository : IUserRepository
    {
        public async Task Create(User user)
        {
            await user.SaveAsync();
        }

        public async Task Delete(string id)
        {
            await DB.DeleteAsync<User>(id);
        }

        public async Task<User> Get(string id)
        {
           var user =  await DB.Find<User>()
                .MatchID(id)
                .ExecuteFirstAsync();
            return user;    
        }

        public async Task<List<User>> GetAll()
        {
            var user =  await DB.Find<User>()
                .ExecuteAsync();
            return user;
        }

        public async Task<User> Update(string id, User user)
        {
            var result =  await DB.UpdateAndGet<User>()
                .MatchID(id)
                .ModifyWith(user)
                .ExecuteAsync();
            return result;
        }
    }
}