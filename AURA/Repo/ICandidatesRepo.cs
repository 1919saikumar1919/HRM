using AURA.Models;

namespace HRM.Repo
{
    public interface ICandidatesRepo
    {
        Task<List<Candidates>> AllCadidates();
    }
}
