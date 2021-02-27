using System;

namespace Verenel.Models.Infrastructure
{
    public interface IModel<TKey>
    {
        /// <summary>
        /// Group site
        /// </summary>
        TKey SiteId { get; set; }

        /// <summary>
        /// Unique object
        /// </summary>
        TKey Id { get; set; }

        int CreateUser { get; set; }
        DateTime CreateionDate { get; set; }
        bool? IsDeleted { get; set; }
        DateTime? DeletionDate { get; set; }
    }
}
