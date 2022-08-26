using Microsoft.EntityFrameworkCore;
using OA_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext _context;
        private readonly DbSet<T> _entities;

        public Repository(ApplicationContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        T IRepository<T>.Get(int id)
        {
            return _entities .SingleOrDefault(p => p.ProductId == id );
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public async Task CreateProduct(ProductDetails productDetails)
        {
            await _context.SaveChangesAsync();
        }
    }
}
