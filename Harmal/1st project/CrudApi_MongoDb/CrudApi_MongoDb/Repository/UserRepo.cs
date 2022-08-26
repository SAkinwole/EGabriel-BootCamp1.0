using CrudApiMongodb.Models;
using MongoDB.Entities;

namespace CrudApiMongodb.Repository
{
    public class UserRepo : IUserRepo
    {
        public async Task CreaterUser(User user)
        {
            await user.SaveAsync();
        }

        public async Task<List<User>> GetAll()
        {
            var users = await DB.Find<User>().Match(_ => true).ExecuteAsync();
            return users;

        }
        public async Task<User> GetOne(String Id)
        {
            var user = await DB.Find<User>()
                .Match(x => x.ID == Id)
                .ExecuteFirstAsync();
            return user;

        }
        public async Task<User> Update(String Id, User user)
        {
            var userUpdate = await DB.UpdateAndGet<User>()
                .MatchID(Id)
                .ModifyWith(user)
                .ExecuteAsync();
            return userUpdate;

        }
        //public async Task<IEnumerable<User>> GetAll()
        //{
        //    await 
        //}
    }
}
