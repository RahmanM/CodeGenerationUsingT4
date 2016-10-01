using System.ComponentModel.DataAnnotations.Schema;

namespace CRM.Entities
{
    [ComplexType]
    public class WebPresense
    {
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Website { get; set; }
        public string Twitter { get; set; }
        public string SecondaryEmail { get; set; }
    }
}