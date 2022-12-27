using BudgetAppOnContainers.Services;

namespace BudgetAppOnContainers.Pages
{
    public partial class Budget
    {
        public BudgetGoals budgetGoals { get; set; } = new BudgetGoals();

        private int savings = 0;

        private void CalculateAmountSavings()
        {
            savings = budgetGoals.TotalSaving / budgetGoals.Month;
        }

    }
}
