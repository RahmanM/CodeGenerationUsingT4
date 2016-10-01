using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using T4.Core;


namespace CRM.Entities
{
    public class State : EntityBase
    {
        public string Code { get; set; }
        [MaxLength(50), StringLength(50)]
        public string Name { get; set; }
        public virtual ICollection<Suburb> Suburbs { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}