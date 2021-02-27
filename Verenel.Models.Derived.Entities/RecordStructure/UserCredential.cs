using System;
using Verenel.Models.Infrastructure;

namespace Verenel.Models.Derived.Entities.RecordStructure
{
    public class UserCredential<TKey> : BaseModel<TKey>, IModel<TKey>
    {
        public TKey UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool CanLogin { get; set; }
        public DateTime CanLoginDate { get; set; }

        public virtual User<TKey> User { get; set; }
    }
}