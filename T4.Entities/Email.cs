using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM.Entities
{
    public class Email
    {
        [Key, ForeignKey("Activity")]
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }

        public string Subject { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Body { get; set; }
        //Todo add entity specific properties
    }
}