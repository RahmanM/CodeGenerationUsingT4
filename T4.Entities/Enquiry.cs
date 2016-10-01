using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM.Entities
{
    public class Enquiry
    {
        [Key, ForeignKey("Activity")]
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }

        public string Details { get; set; }
        //Todo add entity specific properties
    }
}