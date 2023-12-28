using PatternsBack_end.DTOs;
using PatternsBack_end.Interfaces;

namespace PatternsBack_end.Services
{
    public class LabService : ILabService
    {
        private readonly ILabRepository _labRepository;

        public LabService(ILabRepository labRepository)
        {
            _labRepository = labRepository;
        }

        public async Task<IEnumerable<LabDTO>> GetLabList()
        {
            var labList = await _labRepository.GetAll();
            return labList.Select(lab => new LabDTO { LabName = lab.LabName, LabIcon = lab.LabIcon });
        }
    }
}