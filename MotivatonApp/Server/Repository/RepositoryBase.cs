using Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected RepositoryContext RepositoryContext;
        public RepositoryBase(RepositoryContext repositoryContext) => RepositoryContext = repositoryContext;
        public IQueryable<TEntity> FindAll() => RepositoryContext.Set<TEntity>();
        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression) 
               => RepositoryContext.Set<TEntity>().Where(expression);

        public void Create(TEntity entity) => RepositoryContext.Set<TEntity>().Add(entity);
        public void Update(TEntity entity) => RepositoryContext.Set<TEntity>().Update(entity);
        public void Delete(TEntity entity) => RepositoryContext.Set<TEntity>().Remove(entity);
    }
}
