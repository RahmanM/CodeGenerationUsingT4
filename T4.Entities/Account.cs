using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using T4.Core;

namespace CRM.Entities
{
    public class Account : EntityBase
    {
        [MaxLength(250)]
        public string Name { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public WebPresense WebPresense { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Activity> Activities { get; set; }
        //public ICollection<Contact> PrimaryContacts { get; set; }
        public ICollection<Engagement> Engagements { get; set; }
        public int? UserId { get; set; }
        public User AssignedTo { get; set; }
    }

    public class Ball 
    {
        public int Identifications { get; set; }
    }
}
