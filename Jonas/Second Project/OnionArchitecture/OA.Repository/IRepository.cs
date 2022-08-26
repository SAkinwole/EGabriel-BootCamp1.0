using OA.DataAccess;

namespace OA.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Get(int id);

        IEnumerable<T> GetAll();
    }
}