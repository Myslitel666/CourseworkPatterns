using PatternsBack_end.Models.Entities;

namespace PatternsBack_end.Interfaces
{
    public interface IDescriptionLabRepository
    {
        Task<IEnumerable<DescriptionLab>> GetDescriptionLabsWithPriority();
    }
}
