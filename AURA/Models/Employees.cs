using System.Security.Cryptography.X509Certificates;

namespace HRM.Models
{
    public class Employees
    {
        public Guid EmployeeId { get; set; }// guid is a return type like int its create the randome different numbers upto 16 digits.
        public decimal salary { get; set; }
        public string occupation { get; set; }
        public string position { get; set; } = "";
        public DateOnly DateOfJoining { get; set; }
        public string designation { get; set; }
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
