using AURA.Models;
using HRM.Models;

namespace HRM.IServices
{
    public interface IDepartmentServices
    {
        Task<List<Departments>> GetDepartments();
    }
}
