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

        int CreateUserId { get; set; }
        DateTime CreationDate { get; set; }

        int UpdateUserId { get; set; }
        DateTime UpdateDate { get; set; }

        int DeleteUserId { get; set; }
        bool? IsDeleted { get; set; }
        DateTime? DeletionDate { get; set; }
    }
}