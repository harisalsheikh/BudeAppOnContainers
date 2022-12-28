using BudgetAppOnContainers.Services;

namespace BudgetAppOnContainers.Pages
{
    public partial class Repayments
    {
        public LoanRepayments Repayment { get; set; } = new LoanRepayments();

        private decimal totalMonths = 0;

        private double totalRepayments = 0;

        private double interestRate = 0;

        private double monthlyRate = 0;

        double payments = 0;

        private void CalculateMonthlyRepayments()
        {
            totalMonths = Repayment.LoanTerm * 12;

            interestRate = Repayment.InterestRate / 100;

            monthlyRate = interestRate / 12;

            payments = 12 * Repayment.LoanTerm;

            totalRepayments = Math.Round(((double)Repayment.LoanAmount) * (monthlyRate * Math.Pow(1 + monthlyRate, payments))
                / (Math.Pow(1 + monthlyRate, payments) - 1),3);

        }

    }
}
