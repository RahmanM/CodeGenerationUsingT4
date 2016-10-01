using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM.Entities
{
    public class Incident
    {
        [Key, ForeignKey("Engagement")]
        public int EngagementId { get; set; }
        public Engagement Engagement { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        //Todo add entity specific properties
    }
}