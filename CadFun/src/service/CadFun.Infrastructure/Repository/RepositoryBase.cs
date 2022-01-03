using CadFun.Domain.Interfaces;
using CadFun.Domain.Models;
using CadFun.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CadFun.Infrastructure.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : Entity, IAggregateRoot
    {
        private readonly CodFunContext _cotext;
        protected readonly DbSet<T> _dbSet;
        public RepositoryBase(CodFunContext context)
        {
            _cotext = context;
            _dbSet = _cotext.Set<T>();
        }

        public async Task<T> Find(Expression<Func<T, bool>> expression)
        {            
            return await _dbSet.Where(expression).FirstOrDefaultAsync();            
        }

        public async Task Insert(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task Remove(T entity)
        {   
            _dbSet.Remove(entity);            
            await Task.CompletedTask;
        }

        public async Task Update(T entity)
        {
             _dbSet.Update(entity);            
            await Task.CompletedTask;
        }

        public async Task<int> SaveChanges()
        {
            return await _cotext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _cotext?.Dispose();
        }
    }
}
