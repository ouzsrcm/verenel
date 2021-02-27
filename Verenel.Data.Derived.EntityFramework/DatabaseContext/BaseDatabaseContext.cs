using System;
using System.Data.Entity;

namespace Verenel.Data.Derived.EntityFramework.DatabaseContext
{
    public abstract class BaseDatabaseContext : DbContext, IDisposable
    {
        public BaseDatabaseContext()
            : base("name=PrimaryDbContext")
        {

        }
    }
}
