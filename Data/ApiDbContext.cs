using Microsoft.EntityFrameworkCore;
using InvestmentAdvisorAPI.Models; 

namespace InvestmentAdvisorAPI.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        public DbSet<Investment> Investments { get; set; }

    }
}