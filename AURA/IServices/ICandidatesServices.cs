using AURA.Models;

namespace HRM.IServices
{
    public interface ICandidatesServices
    {
        Task<List<Candidates>> AllCadidates();
    }
}
