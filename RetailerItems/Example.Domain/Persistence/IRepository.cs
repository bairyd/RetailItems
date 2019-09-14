using Example.Domain.Model;

namespace Example.Domain.Persistence
{
    public interface IRepository<T> where T : Entity
    {
        T Get(int? id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}