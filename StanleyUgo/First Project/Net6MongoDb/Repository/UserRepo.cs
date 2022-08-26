using MongoDB.Entities;
using Net6MongoDb.Models;

namespace Net6MongoDb.Repository
{
    public class UserRepo : IUserRepo
    {
        public async Task CreateUser(User user)
        {
            await user.SaveAsync();
        }

        public async Task<List<User>> GetAll()
        {
            var users = await DB.Find<User>()
                          .Match(_ => true)
                          .ExecuteAsync();

            return users;
        }

        public async Task<User> Get(string id)
        {
            var user = await DB.Find<User>()
                          .Match(x => x.ID == id)
                          .ExecuteFirstAsync();

            return user;
        }

        public async Task<User> Update(string id, User user)
        {
            var updatedUser = await DB.UpdateAndGet<User>()
                          .MatchID(id)
                          .ModifyWith(user)
                          .ExecuteAsync();

            return updatedUser;
        }
    }
}