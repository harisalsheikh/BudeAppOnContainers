namespace BudgetAppOnContainers.Services
{
    public class BudgetGoals
    {
        public int Month { get; set; }
        public int Day => DateTime.DaysInMonth(DateTime.Now.Year, Month);
        public decimal TotalSaving { get; set; }
    }
}
