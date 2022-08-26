using MongoDB.Entities;
using API_MongoDB.Model;
namespace API_MongoDB.Respository

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


        public async Task<User> GetbyId(string Id)
        {
            var SingleUser = await DB.Find<User>()
                .Match(x => x.ID == Id)
                .ExecuteFirstAsync();

            return SingleUser;
        }

        public async Task<User> Update(string Id, User user)
        {
            var UpdatedUser = await DB.UpdateAndGet<User>()
                   .MatchID(Id).ModifyWith(user)
                   .ExecuteAsync();


            return UpdatedUser;
        }
    }
}

       

       