using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using T4.Core;


namespace CRM.Entities
{
    public class Contact : EntityBase
    {
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        public ICollection<Account> Accounts { get; set; }
        public WebPresense WebPresense { get; set; }
        public string ContactNumber { get; set; }
        public bool IsPrimaryContact { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Activity> Activities { get; set; }
        public ICollection<Engagement> Engagements { get; set; }
    }
}