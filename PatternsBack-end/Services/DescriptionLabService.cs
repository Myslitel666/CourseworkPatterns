using PatternsBack_end.DTOs;
using PatternsBack_end.Interfaces;

namespace PatternsBack_end.Services
{
    public class DescriptionLabService : IDescriptionLabService
    {
        private readonly IDescriptionLabRepository _descriptionLabRepository;

        public DescriptionLabService(IDescriptionLabRepository descriptionLabRepository)
        {
            _descriptionLabRepository = descriptionLabRepository;
        }

        public async Task<IEnumerable<DescriptionLabDTO>> GetPopularDescriptionLabs()
        {
            var descriptionLabs = await _descriptionLabRepository.GetDescriptionLabsWithPriority();
            return descriptionLabs.Select(descLab => new DescriptionLabDTO { LabName = descLab.LabName, ImageUrl = descLab.ImageUrl, LabDescription = descLab.LabDescription });
        }
    }
}