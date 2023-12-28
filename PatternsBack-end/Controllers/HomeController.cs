using Microsoft.AspNetCore.Mvc;
using PatternsBack_end.Interfaces;
using PatternsBack_end.Services;
using System;
using System.Threading.Tasks;

namespace PatternsBack_end.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILabService _labService;
        private readonly IDescriptionLabService _descriptionLabService;

        public HomeController(ILabService labService, IDescriptionLabService descriptionLabService)
        {
            _labService = labService ?? throw new ArgumentNullException(nameof(labService));
            _descriptionLabService = descriptionLabService ?? throw new ArgumentNullException(nameof(descriptionLabService));
        }

        [HttpGet("lab-list")]
        public async Task<IActionResult> GetLabList()
        {
            try
            {
                var labList = await _labService.GetLabList();
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
                var descriptionLabs = await _descriptionLabService.GetPopularDescriptionLabs();
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