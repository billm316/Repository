using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public string ConnectionString => "Data Source=PMD1SQLDW1P;Initial Catalog=Firazyr;Integrated Security=True;MultipleActiveResultSets=True";

        public Repository()
        {
        }

        public void Add(TEntity entity)
        {
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
        }

        public abstract IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        public abstract TEntity Get(long id);

        public abstract IEnumerable<TEntity> GetAll();

        public void Remove(TEntity entity)
        {
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
        }
    }
}
