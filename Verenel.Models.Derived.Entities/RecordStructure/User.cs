using System.Collections.Generic;
using Verenel.Models.Infrastructure;

namespace Verenel.Models.Derived.Entities.RecordStructure
{
    public class User<TKey> : BaseModel<TKey>, IEntityModel<TKey>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }
        public string Phone { get; set; }
        public string ProfileImage { get; set; }

        public virtual ICollection<UserCredential<TKey>> UserCredentials { get; set; }
    }
}