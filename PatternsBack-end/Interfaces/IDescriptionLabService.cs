using PatternsBack_end.DTOs;

namespace PatternsBack_end.Interfaces
{
    public interface IDescriptionLabService
    {
        Task<IEnumerable<DescriptionLabDTO>> GetPopularDescriptionLabs();
    }
}
