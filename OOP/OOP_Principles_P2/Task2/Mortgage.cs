namespace Task2
{
    using System;

    public class Mortgage : BankAccount, IDeposit
    {
        private const int MONTHS_WITH_HALF_INTEREST = 12;
        private const double HALF_INTEREST = 0.5;

        public Mortgage() : base()
        {

        }

        public Mortgage(Customer customer, double balance, double interestRate) : base(customer, balance, interestRate)
        {

        }

        public override double GetInterestAmount(int numberOfMonths)
        {
            double interestAmount = 0;

            if (numberOfMonths >= MONTHS_WITH_HALF_INTEREST)
            {
                numberOfMonths -= MONTHS_WITH_HALF_INTEREST;
                interestAmount = interestAmount + MONTHS_WITH_HALF_INTEREST * HALF_INTEREST * this.InterestRate;
            }
            interestAmount = interestAmount + numberOfMonths * this.InterestRate;
            return interestAmount;
        }

        public void MakeDeposit(double depositAmount)
        {
            this.Balance += depositAmount;
        }
    }
}
