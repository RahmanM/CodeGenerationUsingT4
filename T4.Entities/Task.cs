using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM.Entities
{
    public class Task
    {
        [Key, ForeignKey("Activity")]
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }

        public string Details { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime FinishTime { get; set; }
        //Todo add entity specific properties
    }
}