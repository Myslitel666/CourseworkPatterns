using Microsoft.EntityFrameworkCore;
using PatternsBack_end.Context;
using PatternsBack_end.Interfaces;
using PatternsBack_end.Models;
using PatternsBack_end.Models.Entities;

namespace PatternsBack_end.Repositories
{
    public class LabRepository : ILabRepository
    {
        private readonly PatternsContext _dbContext;

        public LabRepository(PatternsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Lab>> GetAll()
        {
            return await _dbContext.Labs.ToListAsync();
        }
    }
}