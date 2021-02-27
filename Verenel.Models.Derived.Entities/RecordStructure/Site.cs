using Verenel.Models.Infrastructure;

namespace Verenel.Models.Derived.Entities.RecordStructure
{
    public class Site<TKey> : BaseModel<TKey>, IModel<TKey>
    {
        public string BaseUrl { get; set; }
        public string HttpUrl { get; set; }
        public string HttpsUrl { get; set; }
        public bool IsOnline { get; set; }
        public bool IsInMaintenance { get; set; }
        public string MaintenancePageUrl { get; set; }
    }
}