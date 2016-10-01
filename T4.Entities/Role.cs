using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using T4.Core;


namespace CRM.Entities
{
    public class Role : EntityBase
    {
        [Required(ErrorMessage = "Role is required."), MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(100), StringLength(100)]
        public string RoleDescription { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}