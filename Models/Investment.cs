namespace InvestmentAdvisorAPI.Models
{
    public class Investment
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public decimal MinimumAmount { get; set; }
        public decimal ExpectedReturn { get; set; }
        public string? RiskLevel { get; set; }
    }
}