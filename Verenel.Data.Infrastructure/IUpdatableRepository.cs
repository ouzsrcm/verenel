using Verenel.Data.Infrastructure.Dependency;
using Verenel.Models.Derived.Entities;

namespace Verenel.Data.Infrastructure
{
    public interface IUpdatableRepository<TEntity, TKey> : 
        IRepository<TEntity, TKey> where TEntity : class, 
        IEntityModel<TKey>,
        IScopedDependency,
        ITransactionDependency
    {
        TEntity Update(TEntity model);
    }
}