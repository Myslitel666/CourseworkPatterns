using Microsoft.EntityFrameworkCore;
using PatternsBack_end.Context;
using PatternsBack_end.Interfaces;
using PatternsBack_end.Models;
using PatternsBack_end.Models.Entities;

namespace PatternsBack_end.Repositories
{
    public class DescriptionLabRepository : IDescriptionLabRepository
    {
        private readonly PatternsContext _dbContext;

        public DescriptionLabRepository(PatternsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<DescriptionLab>> GetPopularDescriptionLabs()
        {
            return await _dbContext.DescriptionLabs
                .OrderByDescending(p => p.Priority)
                .Take(6)
                .ToListAsync();
        }
    }
}