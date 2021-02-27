using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verenel.Models.Infrastructure;

namespace Verenel.Models.Derived.Entities
{
    public interface IEntityModel<TKey> : IModel<TKey>
    {
    }
}
