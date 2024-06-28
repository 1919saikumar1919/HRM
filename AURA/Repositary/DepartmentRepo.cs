using HRM.Models;
using HRM.Repo;

namespace HRM.Repositary
{
    public class DepartmentRepo : IDepartmentsRepo
    {
        public Task<List<Departments>> GetDepartment()
        {
            throw new NotImplementedException();
        }
    }
}
