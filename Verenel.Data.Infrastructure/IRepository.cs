using Verenel.Models.Infrastructure;

namespace Verenel.Data.Infrastructure
{
    public interface IRepository<TEntity, TKey> where TEntity : class, IModel<TKey>
    {

    }
}
