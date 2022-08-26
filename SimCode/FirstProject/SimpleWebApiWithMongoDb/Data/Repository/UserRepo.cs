using MongoDB.Entities;
using SimpleWebApiWithMongoDb.Models.Users;

namespace SimpleWebApiWithMongoDb.Data.Repository
{
    public class UserRepo : IUserRepo
    {
        public async Task CreateUser(User user)
        {
            await user.SaveAsync();
        }

        public async Task<List<User>> GetUsers()
        {
            var users = await DB.Find<User>().Match(_ => true).ExecuteAsync(); 
            return users;
        }

        public async Task<User> GetUser(string Id)
        {
            var user = await DB.Find<User>().Match(u => u.ID == Id).ExecuteFirstAsync();
            return user;
        }

        public async Task<User> UpdateUser(string Id, User user)
        {
            var updateUser = await DB.UpdateAndGet<User>().MatchID(Id).ModifyWith(user).ExecuteAsync();
            return updateUser;
        }
    }
}
