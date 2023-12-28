using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using PatternsBack_end.Models;
using Microsoft.EntityFrameworkCore;

namespace PatternsBack_end.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private PatternsContext _dbContext;

        public HomeController()
        {
            _dbContext = new PatternsContext();
        }

        [HttpGet("lab-list")]
        public async Task<IActionResult> GetLabList()
        {
            try
            {
                var labList = await _dbContext.Labs
                    .Where(c => c.LabId != null)
                    .Select(c => new { LabName = c.LabName, LabIcon = c.LabIcon })
                    .ToListAsync();

                return Ok(labList);
            }
            catch (Exception ex)
            {
                // Логируйте ошибку или верните ошибку сервера
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }

        [HttpGet("description-lab")]
        public async Task<IActionResult> GetDescriptionLabs()
        {
            try
            {
                var descriptionLabs = await _dbContext.DescriptionLabs
                    .OrderByDescending(p => p.Priority)
                    .Take(6) // Получить 6 самых популярных товаров
                    .ToListAsync();

                return Ok(descriptionLabs);
            }
            catch (Exception ex)
            {
                // Логируйте ошибку или верните ошибку сервера
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
            }
        }
    }
}
