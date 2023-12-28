using PatternsBack_end.DTOs;

namespace PatternsBack_end.Interfaces
{
    public interface ILabService
    {
        Task<IEnumerable<LabDTO>> GetLabList();
    }
}
