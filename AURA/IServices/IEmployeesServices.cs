using HRM.Models;

namespace HRM.IServices
{
    public interface IEmployeesServices
    {
        Task<List<Employees>> AllEmployees();
    }
}
