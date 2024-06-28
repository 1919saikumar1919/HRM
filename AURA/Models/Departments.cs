using System.ComponentModel.DataAnnotations;

namespace HRM.Models
{
    public class Departments
    {
        [Key]
        public Guid DepartmentId { get; set; }   
        public string DepartmentName { get; set; }
    }
}
