using Verenel.Data.Infrastructure.Dependency;
using Verenel.Models.Derived.Entities;

namespace Verenel.Data.Infrastructure
{
    public interface IRepository<TEntity, TKey> where TEntity : class, IScopedDependency, ITransactionDependency, IEntityModel<TKey>
    {

    }
}