using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using T4.Core;


namespace CRM.Entities
{
    public class Country : EntityBase
    {
        [MaxLength(50), StringLength(50)]
        public string Name { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}