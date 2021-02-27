using System;
using System.Linq;
using System.Linq.Expressions;
using Verenel.Models.Infrastructure;

namespace Verenel.Data.Infrastructure
{
    public interface ISelectableRepository<TEntity, TKey> where TEntity : class, IRepository<TEntity, TKey>, IModel<TKey>
    {
        IQueryable<TEntity> GetList();
        IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> model);
        TEntity Get(Expression<Func<TEntity, bool>> model);
        bool Exists(Expression<Func<TEntity, bool>> model);
        int Count(Expression<Func<TEntity, bool>> model);
    }
}