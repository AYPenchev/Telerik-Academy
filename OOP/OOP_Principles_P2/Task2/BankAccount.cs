namespace Task2
{
    using System;

    public abstract class BankAccount : IGetInterestAmount
    {
        protected const int DEPOSIT_LIMIT_WITHOUT_TAX = 5000;
        protected const double DEPOSIT_PERCENT_TAX = 0.05;
        protected const double WITHDRAW_PERCENT_TAX = 2.4;

        protected BankAccount()
        {
            this.Customer = null;
            this.Balance = default(double);
        }

        protected BankAccount(Customer customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        protected Customer Customer { get; set; }
        protected double Balance { get; set; }
        protected double InterestRate { get; set; }

        public abstract double GetInterestAmount(int numberOfMonths);
    }
}
