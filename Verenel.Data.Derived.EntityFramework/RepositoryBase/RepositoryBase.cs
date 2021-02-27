using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Verenel.Data.Derived.EntityFramework.DatabaseContext;
using Verenel.Data.Infrastructure;
using Verenel.Data.Infrastructure.Dependency;
using Verenel.Models.Derived.Entities;

namespace Verenel.Data.Derived.EntityFramework.RepositoryBase
{
    public abstract class RepositoryBase<OC, TEntityModel, TKey> :

        ISelectableRepository<TEntityModel, TKey>,
        IUpdatableRepository<TEntityModel, TKey>,
        IInsertableRepository<TEntityModel, TKey>,
        IDeletableRepository<TEntityModel, TKey>
        where TEntityModel : class, IEntityModel<TKey>,
        IScopedDependency,
        ITransactionDependency
        where OC : BaseDatabaseContext,
        IDisposable, new()
    {

        private readonly BaseDatabaseContext context;
        public readonly DbSet<TEntityModel> dbSet;
        private readonly IQueryable<TEntityModel> queryEntity;

        public RepositoryBase()
        {
            this.context = new OC();
            dbSet = context.Set<TEntityModel>();
            queryEntity = dbSet.Where(x => x.IsDeleted == false).AsNoTracking();
        }

        public int Count(Expression<Func<TEntityModel, bool>> model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TEntityModel model)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<TEntityModel, bool>> model)
        {
            throw new NotImplementedException();
        }

        public TEntityModel Get(Expression<Func<TEntityModel, bool>> model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntityModel> GetList()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntityModel> GetList(Expression<Func<TEntityModel, bool>> model)
        {
            throw new NotImplementedException();
        }

        public TEntityModel Insert(TEntityModel model)
        {
            throw new NotImplementedException();
        }

        public TEntityModel Update(TEntityModel model)
        {
            throw new NotImplementedException();
        }
    }
}