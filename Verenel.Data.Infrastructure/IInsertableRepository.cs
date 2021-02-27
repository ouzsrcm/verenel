using Verenel.Models.Infrastructure;

namespace Verenel.Data.Infrastructure
{
    public interface IInsertableRepository<TEntity, TKey> where TEntity : class, IRepository<TEntity, TKey>, IModel<TKey>
    {
        TEntity Insert(TEntity model);
    }
}