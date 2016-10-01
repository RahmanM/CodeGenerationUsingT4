using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM.Entities
{
    public class Todo
    {
        [Key, ForeignKey("Activity")]
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
        public string Details { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartTime { get; set; }
        //Todo add entity specific properties
    }
}