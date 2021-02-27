using System;

namespace Verenel.Models.Infrastructure
{
    public class BaseModel<TKey> : IModel<TKey>
    {
        public TKey SiteId { get; set; }
        public TKey Id { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateionDate { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletionDate { get; set; }
    }
}
