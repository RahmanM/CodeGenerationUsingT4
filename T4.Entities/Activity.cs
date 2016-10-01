using System.ComponentModel.DataAnnotations;
using T4.Core;


namespace CRM.Entities
{
    public class Activity : EntityBase
    {
        [MaxLength(100), StringLength(100)]
        public string Description { get; set; }

        public int ActivityTypeId { get; set; }
        public ActivityType ActivityType { get; set; }

        public Email Email { get; set; }
        public Task Task { get; set; }
        public Enquiry Enquiry { get; set; }
        public Todo Todo { get; set; }
        public int? UserId { get; set; }
        public User AssignedTo { get; set; }
    }
}