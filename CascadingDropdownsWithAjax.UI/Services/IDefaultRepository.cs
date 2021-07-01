using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CascadingDropdownsWithAjax.UI.Services
{
    public interface IDefaultRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filterEntities = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> sortEntities = null,
            string navigationProperties = null);
        TEntity GetFirstOrDefaultType(Expression<Func<TEntity, bool>> filterEntities = null,
             string navigationProperties = null);
        void AddTypeToDb(TEntity entityToBeAdded);

        void Remove(TEntity entity);
        void Remove(int id);

       
    }
}
