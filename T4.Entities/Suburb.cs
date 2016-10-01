using System.ComponentModel.DataAnnotations;
using T4.Core;


namespace CRM.Entities
{
    public class Suburb : EntityBase
    {
        [MaxLength(50), StringLength(50)]
        public string Name { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
    }
}