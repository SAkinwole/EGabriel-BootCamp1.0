using MongoDB.Entities;
using Net6MongoDB.Models;

namespace Net6MongoDB.Repository
{
    public class UserRepo:IuserRepo
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
        public async Task<User> GetById(string Id)
        {
            var user = await DB.Find<User>()
                .Match(x => x.ID == Id)
                .ExecuteFirstAsync();
            return user;
        }
        public async Task<User> UpdateUser(string Id,User user)
        {
            var updatedUser = await DB.UpdateAndGet<User>()
                .MatchID(Id)
                .ModifyWith(user)
                .ExecuteAsync();
            return updatedUser;
        }

    }
    
}
