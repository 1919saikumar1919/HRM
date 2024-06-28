using HRM.Models;
using HRM.Repo;

namespace HRM.Repositary
{
    public class EmployeeRepo : IEmployeesRepo

    {
        public Task<List<Employees>> AllEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
