using Microsoft.EntityFrameworkCore;
using OA.DataAccess;

namespace OA.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext context;

        private readonly DbSet<T> entities;

        public Repository(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public T Get(int id)
        {
            return entities.SingleOrDefault(x => x.ProductId == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
    }
}