using API_MongoDB.Model;


namespace API_MongoDB.Respository
{
    public interface IUserRepo
    {
        Task CreateUser(User user);
       
        Task<List<User>> GetAll();
        Task <User> GetbyId (string Id);
        Task <User> Update(string Id, User user);
        

    }
}
