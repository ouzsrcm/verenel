using System.Collections.Generic;
using Verenel.Models.Infrastructure;

namespace Verenel.Models.Derived.Entities.RecordStructure
{
    public class Category<TKey> : BaseModel<TKey>, IModel<TKey>
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }

        public virtual ICollection<Article<TKey>> Articles { get; set; }
    }
}