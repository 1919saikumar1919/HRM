using HRM.Models;

namespace HRM.Repo
{
    public interface IEmployeesRepo
    {
        Task<List<Employees>> AllEmployees();
    }
}
