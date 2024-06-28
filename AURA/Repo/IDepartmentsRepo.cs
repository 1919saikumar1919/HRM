using AURA.Models;
using HRM.Models;

namespace HRM.Repo
{
    public interface IDepartmentsRepo
    {
        Task<List<Departments>> GetDepartment();
       
       
      

    }
}
