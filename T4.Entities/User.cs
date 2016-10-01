using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using T4.Core;


namespace CRM.Entities
{
    public class User : EntityBase
    {
        [Required(ErrorMessage = "User name (email) is required."), MaxLength(100), StringLength(100)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required."), MaxLength(12), StringLength(12)]
        public string Password { get; set; }
        [Required(ErrorMessage = "First Name is required."), MaxLength(25), StringLength(25)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required."), MaxLength(25), StringLength(25)]
        public string LastName { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}