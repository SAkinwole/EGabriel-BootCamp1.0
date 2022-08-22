using MongoDB.Entities;
using Net6Mongo.Models;
using Net6Mongo.Models.Repository;

namespace Net6Mongo.Repository
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

        public async Task<User> Get (string Id)
        {
            var user = await DB.Find<User>()
                        .Match(x => x.ID == Id)
                        .ExecuteFirstAsync();

            return user;
        }

        public async Task<User> Update(string Id, User user)
        {
            var updatedUser = await DB.UpdateAndGet<User>()
                        .Match(Id)
                        .ModifyWith(user)
                        .ExecuteAsync();

            return updatedUser;
        }
    }
}