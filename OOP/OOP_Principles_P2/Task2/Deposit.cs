namespace Task2
{
    using System;

    public class Deposit : BankAccount, IDeposit, IWithdraw
    {
        public Deposit() : base()
        {

        }

        public Deposit(Customer customer, double balance, double interestRate) : base(customer, balance, interestRate)
        {

        }

        public override double GetInterestAmount(int numberOfMonths)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }

            double interestAmount = numberOfMonths * this.InterestRate;
            return interestAmount;
        }

        public void MakeDeposit(double depositAmount)
        {
            this.Balance += depositAmount;

            if (depositAmount > DEPOSIT_LIMIT_WITHOUT_TAX)
            {
                this.Balance = this.Balance - (depositAmount * DEPOSIT_PERCENT_TAX);
            }
        }

        public void Withdraw(double withdrawAmount)
        {
            this.Balance = this.Balance - (withdrawAmount +  this.CalculatePercentageOf(withdrawAmount, WITHDRAW_PERCENT_TAX));
        }

        private double CalculatePercentageOf(double amount, double percent)
        {
            return amount * percent / 100;
        }
    }
}
