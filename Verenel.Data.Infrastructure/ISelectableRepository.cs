using System;
using System.Linq;
using System.Linq.Expressions;
using Verenel.Data.Infrastructure.Dependency;
using Verenel.Models.Derived.Entities;

namespace Verenel.Data.Infrastructure
{
    public interface ISelectableRepository<TEntity, TKey> :
        IRepository<TEntity, TKey> where TEntity : class,
        IEntityModel<TKey>,
        IScopedDependency,
        ITransactionDependency
    {
        IQueryable<TEntity> GetList();
        IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> model);
        TEntity Get(Expression<Func<TEntity, bool>> model);
        bool Exists(Expression<Func<TEntity, bool>> model);
        int Count(Expression<Func<TEntity, bool>> model);
    }
}