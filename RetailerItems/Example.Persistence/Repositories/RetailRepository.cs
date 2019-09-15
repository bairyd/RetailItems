using System.Linq;
using System.Threading.Tasks;
using Example.Domain.Model;
using Example.Domain.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Example.Persistence.Repositories
{
    public class RetailRepository<T> : IRepository<T> where T : Entity
    {
        private readonly RetailDbContext _dbContext;

        public RetailRepository(RetailDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>().AsNoTracking().Include(x=> x);
        }

        public async Task<T> GetById(int id)
        {
            return await _dbContext.Set<T>()
                .AsNoTracking()
                .FirstOrDefaultAsync(entity => entity.Id == id);
        }

        public async Task Create(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(int id, T entity)
        {
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}