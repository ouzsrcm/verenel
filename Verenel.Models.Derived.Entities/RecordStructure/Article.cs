using System;
using Verenel.Models.Infrastructure;

namespace Verenel.Models.Derived.Entities.RecordStructure
{
    public class Article<TKey> : BaseModel<TKey>, IModel<TKey>
    {
        public string Title { get; set; }
        public TKey CategoryId { get; set; }
        public string ShortDescription { get; set; }
        public string Content { get; set; }
        public string CoverImage { get; set; }
        public string SeoUrl { get; set; }
        public string Permalink { get; set; }
        public bool IsPublished { get; set; }
        public DateTime PublishDate { get; set; }

        public virtual Category<TKey> Category { get; set; }
    }
}