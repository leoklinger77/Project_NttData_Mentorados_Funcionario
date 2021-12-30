using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CadFun.Domain.Interfaces
{
    public interface IRepository<A> : IDisposable where A : IAggregateRoot
    {
        Task<A> Find(Expression<Func<A, bool>> expression);
        Task Insert(A entity);
        Task Update(A entity);
        Task Remove(A entity);        
    }
}
