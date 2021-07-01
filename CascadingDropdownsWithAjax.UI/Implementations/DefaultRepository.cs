using CascadingDropdownsWithAjax.UI.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CascadingDropdownsWithAjax.UI.Implementations
{
    public class DefaultRepository<T> : IDefaultRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        internal DbSet<T> _dbSet;
        public DefaultRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public void AddTypeToDb(T entityToBeAdded)
        {
            _dbSet.Add(entity: entityToBeAdded);
        }

        public T Get(int id)
        {
            return _dbSet.Find(id);
        }
        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filterEntities = null, Func<IQueryable<T>, IOrderedQueryable<T>> sortEntities = null, string navigationProperties = null)
        {
            IQueryable<T> query = _dbSet;

            if (filterEntities != null)
            {
                query = query.Where(filterEntities);
            }

            if (navigationProperties != null)
            {
                foreach (var property in navigationProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query.Include(property);
                }
            }


            if (sortEntities != null)
            {
                return sortEntities?.Invoke(query).ToList();
            }

            return query.ToList();


        }
        public T GetFirstOrDefaultType(Expression<Func<T, bool>> filterEntities = null, string navigationProperties = null)
        {
            IQueryable<T> query = _dbSet;

            if (filterEntities != null)
            {
                query = query.Where(filterEntities);
            }

            if (navigationProperties != null)
            {
                foreach (var property in navigationProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query.Include(property);
                }
            }

            return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Remove(int id)
        {
            var result = _dbSet.Find(id);
            _dbSet.Remove(result);
        }
    }
}
