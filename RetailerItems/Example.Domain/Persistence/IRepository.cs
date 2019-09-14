using System.Linq;
using System.Threading.Tasks;
using Example.Domain.Model;

namespace Example.Domain.Persistence
{
    public interface IRepository<T> where T : Entity
    {
        IQueryable<T> GetAll();
 
        Task<T> GetById(int id);
 
        Task Create(T entity);
 
        Task Update(int id, T entity);
 
        Task Delete(int id);
    }
}