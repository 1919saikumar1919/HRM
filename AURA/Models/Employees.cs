using AURA.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace HRM.Models
{
    public class Employees
    {
        [Key]
        public Guid EmployeeId { get; set; }// guid is a return type like int its create the randome different numbers upto 16 digits.
        public long Salary { get; set; }
        public string Occupation { get; set; }
        public string Position { get; set; } = "";
        public DateTime DateOfJoining { get; set; }
        public Status Status { get; set; }

        public string Designation { get; set; }
        
        public Guid DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Departments DepartmetsData { get; set; }
        
        public Guid CandidateId { get; set; }
        [ForeignKey("CandidateId")]
        public Candidates CandidatesData { get; set; }











    }
    public enum Status
    {
        Active,
        Inactive,
        Terminated


    }

}
