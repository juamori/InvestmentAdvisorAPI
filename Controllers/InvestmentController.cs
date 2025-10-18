using Microsoft.AspNetCore.Mvc;
using InvestmentAdvisorAPI.Models;
using InvestmentAdvisorAPI.Services;

namespace InvestmentAdvisorAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class InvestmentController : ControllerBase
    {
        private readonly InvestmentService _service;

        public InvestmentController(InvestmentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Investment>>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Investment>> GetById(int id)
        {
            var investment = await _service.GetByIdAsync(id);
            if (investment == null)
            {
                return NotFound(); 
            }
            return investment;
        }

        [HttpPost]
        public async Task<ActionResult<Investment>> Create(Investment investment)
        {
            await _service.CreateAsync(investment);
            return CreatedAtAction(nameof(GetById), new { id = investment.Id }, investment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Investment investment)
        {
            if (id != investment.Id)
            {
                return BadRequest(); 
            }

            await _service.UpdateAsync(investment);
            return NoContent(); 
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var investment = await _service.GetByIdAsync(id);
            if (investment == null)
            {
                return NotFound();
            }

            await _service.DeleteAsync(id);
            return NoContent(); 
        }
    }
}