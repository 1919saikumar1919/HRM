using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace HRM.Models
{
    public class Parsons
    {
        [Key]
        public Guid ParsonId { get; set; }// guid is a return type like int its create the randome different numbers upto 16 digits.
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = "";
        public string Genger { get; set; } = "";
        public string Materialstatus { get; set; } = "";
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Address { get; set; } = "";
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; }  
    }
}
