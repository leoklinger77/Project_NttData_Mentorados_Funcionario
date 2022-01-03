using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CadFun.Domain.Interfaces
{
    public interface IRepositoryBase<T> : IDisposable where T : IAggregateRoot
    {
        Task<T> Find(Expression<Func<T, bool>> expression);
        Task Insert(T entity);
        Task Update(T entity);
        Task Remove(T entity);

        Task<int> SaveChanges();
    }
}
