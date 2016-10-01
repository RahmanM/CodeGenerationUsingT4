using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using T4.Core;


namespace CRM.Entities
{
    public class Address : EntityBase
    {
        [MaxLength(40), StringLength(40)]
        public string StreetName { get; set; }
        [MaxLength(10), StringLength(10)]
        public string StreetNo { get; set; }
        [MaxLength(10), StringLength(10)]
        public string HomeNumber { get; set; }
        [MaxLength(10), StringLength(10)]
        public string Postcode { get; set; }
        public int? SuburbId { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public virtual Suburb Suburb { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual Account Account { get; set; }
        public int AddressTypeId { get; set; }
        public virtual AddressType AddressType { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; } 
    }
}