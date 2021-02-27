using Verenel.Models.Infrastructure;

namespace Verenel.Data.Infrastructure
{
    public interface IDeletableRepository<TEntity, TKey> where TEntity: class, IRepository<TEntity, TKey>,IModel<TKey>
    {
        bool Delete(TEntity model);
    }
}