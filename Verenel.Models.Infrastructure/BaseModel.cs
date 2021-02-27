using System;

namespace Verenel.Models.Infrastructure
{
    public class BaseModel : IModel<Guid>
    {
        public Guid SiteId { get; set; }
        public Guid Id { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateionDate { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletionDate { get; set; }
    }
}
