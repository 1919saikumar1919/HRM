using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace HRM.Models
{
    public class Employees
    {
        [Key]
        public Guid EmployeeId { get; set; }// guid is a return type like int its create the randome different numbers upto 16 digits.
        public decimal Salary { get; set; }
        public string Occupation { get; set; }
        public string Position { get; set; } = "";
        public DateOnly DateOfJoining { get; set; }
        public string Designation { get; set; }
        public Guid DepartmentId { get; set; }
        public status Status { get; set; }






    }
    public enum status
    {
        Active,
        Inactive,
        Terminated


    }

}
