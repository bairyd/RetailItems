using Example.Domain.Model;
using Example.Domain.Persistence;

namespace Example.Persistence.Repositories
{
    public class RetailRepository<T> : IRepository<T> where T : Entity
    {
        public T Get(int? id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}