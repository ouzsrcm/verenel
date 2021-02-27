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

        protected void TrackingControl(TEntityModel item)
        {
            bool tracking = context.ChangeTracker.Entries<TEntityModel>().Any(x => x.Entity.Id.Equals(item.Id));
            if (tracking)
                context.ChangeTracker.Entries<TEntityModel>().FirstOrDefault(x => x.Entity.Id.Equals(item.Id)).State = EntityState.Detached;
        }

        public int Count(Expression<Func<TEntityModel, bool>> model)
        {
            return queryEntity.Count(model);
        }

        public bool Delete(TEntityModel model)
        {
            model.IsDeleted = true;
            TrackingControl(model);
            dbSet.Attach(model);
            context.Entry(model).State = EntityState.Modified;
            context.SaveChanges();
            return true;
        }

        public bool Exists(Expression<Func<TEntityModel, bool>> model)
        {
            return queryEntity.Any(model);
        }

        public TEntityModel Get(Expression<Func<TEntityModel, bool>> model)
        {
            return queryEntity.Where(model).FirstOrDefault();
        }

        public IQueryable<TEntityModel> GetList()
        {
            return queryEntity.AsNoTracking();
        }

        public IQueryable<TEntityModel> GetList(Expression<Func<TEntityModel, bool>> model)
        {
            return queryEntity.Where(model).AsNoTracking();
        }

        public TEntityModel Insert(TEntityModel model)
        {
            model.CreationDate = DateTime.Now;
            var res = dbSet.Add(model);
            context.SaveChanges();
            return res;
        }

        public TEntityModel Update(TEntityModel model)
        {
            model.UpdateDate = DateTime.Now;
            TrackingControl(model);
            dbSet.Attach(model);
            context.Entry(model).State = EntityState.Modified;
            context.SaveChanges();
            return model;
        }
    }
}