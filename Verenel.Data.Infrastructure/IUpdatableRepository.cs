using Verenel.Models.Infrastructure;

namespace Verenel.Data.Infrastructure
{
    public interface IUpdatableRepository<TEntity, TKey> where TEntity : class, IRepository<TEntity, TKey>, IModel<TKey>
    {
        TEntity Update(TEntity model);
    }
}
