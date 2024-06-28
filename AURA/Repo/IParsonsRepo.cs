using HRM.Models;

namespace HRM.Repo
{
    public interface IParsonsRepo
    {
        Task<List<Parsons>> AllParsons();

    }
}
