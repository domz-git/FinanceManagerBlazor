using System.Collections.Generic;

namespace FinanceManager.Storage
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Remove(T entity);
        IEnumerable<T> GetAll();
    }
}
