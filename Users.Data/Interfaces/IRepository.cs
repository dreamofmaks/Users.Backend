using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Users.Data.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        TEntity GetById(params object[] keys);

        TEntity Add(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);

        bool Delete(TEntity entity);

        void DeleteRange(IEnumerable<TEntity> entities);

        TEntity Update(TEntity entity);

        public IQueryable<TEntity> Query(params Expression<Func<TEntity, object>>[] includes);
    }
}
