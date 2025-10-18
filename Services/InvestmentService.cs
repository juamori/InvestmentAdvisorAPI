using InvestmentAdvisorAPI.Data;
using InvestmentAdvisorAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InvestmentAdvisorAPI.Services
{
    public class InvestmentService
    {
        private readonly ApiDbContext _context; 

        public InvestmentService(ApiDbContext context)
        {
            _context = context;
        }

        public async Task<List<Investment>> GetAllAsync()
        {
            return await _context.Investments.ToListAsync();
        }

        public async Task<Investment?> GetByIdAsync(int id)
        {
            return await _context.Investments.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task CreateAsync(Investment investment)
        {
            _context.Investments.Add(investment);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Investment investment)
        {
            _context.Entry(investment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var investment = await _context.Investments.FindAsync(id);
            if (investment != null)
            {
                _context.Investments.Remove(investment);
                await _context.SaveChangesAsync();
            }
        }
    }
}