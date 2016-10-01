using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM.Entities
{
    public class Oppertunity
    {
        [Key, ForeignKey("Engagement")]
        public int EngagementId { get; set; }
        public Engagement Engagement { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public decimal Probability { get; set; }
        //public int? UserId { get; set; }
        //public User AssignedTo { get; set; }
        public decimal Amount { get; set; }
        public int? CampaignId { get; set; }
        public Campaign Campaign { get; set; }
    }
}