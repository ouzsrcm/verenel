using Verenel.Data.Infrastructure.Dependency;
using Verenel.Models.Derived.Entities;

namespace Verenel.Data.Infrastructure
{
    public interface IDeletableRepository<TEntity, TKey> : 
        IRepository<TEntity, TKey> where TEntity : class, 
        IEntityModel<TKey>,
        IScopedDependency,
        ITransactionDependency
    {
        bool Delete(TEntity model);
    }
}