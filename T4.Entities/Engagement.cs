using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using T4.Core;


namespace CRM.Entities
{
    public class Engagement : EntityBase
    {
        [MaxLength(100), StringLength(100)]
        public string Description { get; set; }
        public string Details { get; set; }
        public int EngagementTypeId { get; set; }
        public int? AccountId { get; set; }
        public Account Account { get; set; }
        public int? ContactId { get; set; }
        public Contact Contact { get; set; }
        public int StageId { get; set; }
        public Stage Stage { get; set; }
        public ICollection<Activity> Activities { get; set; }
        public Incident Incident { get; set; }
        public Case Case { get; set; }
        public Campaign Campaign { get; set; }
        public Oppertunity Oppertunity { get; set; }

        public int? UserId { get; set; }
        public User AssignedTo { get; set; }
    }
}