using System.ComponentModel.DataAnnotations;
using T4.Core;


namespace CRM.Entities
{
    public class ActivityType : EntityBase
    {
        [MaxLength(100), StringLength(100)]
        public string Description { get; set; }
        [MaxLength(10), StringLength(10)]
        public string Code { get; set; }
    }
}