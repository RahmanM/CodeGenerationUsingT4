using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using T4.Core;


namespace CRM.Entities
{
    public class EngagementType : EntityBase
    {
        [MaxLength(100), StringLength(100)]
        public string Description { get; set; }
        [MaxLength(10), StringLength(10)]
        public string Code { get; set; }

        public ICollection<Engagement> Engagements { get; set; }
        public ICollection<Stage> Stages { get; set; }
    }
}