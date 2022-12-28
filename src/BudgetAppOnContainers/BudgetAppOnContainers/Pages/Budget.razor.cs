using BudgetAppOnContainers.Services;

namespace BudgetAppOnContainers.Pages
{
    public partial class Budget
    {
        public BudgetGoals budgetGoals { get; set; } = new BudgetGoals();

        private decimal savings = 0;

        private void CalculateAmountSavings()
        {
            savings = Math.Round(budgetGoals.TotalSaving / budgetGoals.Month,2);

        }

    }
}
