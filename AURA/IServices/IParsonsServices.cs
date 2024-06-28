using HRM.Models;

namespace HRM.IServices
{
    public interface IParsonsServices
    {

        Task<List<Parsons>> AllParsons();

    }
}
