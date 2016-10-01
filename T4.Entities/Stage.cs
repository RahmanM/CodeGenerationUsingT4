using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using T4.Core;


namespace CRM.Entities
{
    public class Stage : EntityBase
    {
        public string Description { get; set; }
        [MaxLength(10), StringLength(10)]
        public string Code { get; set; }
        public bool IsCompleted { get; set; }
        public int Sequence { get; set; }
        public bool IsMandatory { get; set; }
        public ICollection<EngagementType> EngagementTypes { get; set; }
    }
}