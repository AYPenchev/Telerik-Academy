namespace Task2
{
    using System;

    public class Loan : BankAccount, IDeposit
    {
        private const int MONTHS_WITHOUT_INTEREST_INDIVIDUAL = 3;
        private const int MONTHS_WITHOUT_INTEREST_COMPANY = 2;


        public Loan() : base()
        {

        }

        public Loan(Customer customer, double balance, double interestRate) : base(customer, balance, interestRate)
        {

        }

        public override double GetInterestAmount(int numberOfMonths)
        {
            if (this.Customer.GetType() == typeof(Individual).GetType())
            {
                if (numberOfMonths >= MONTHS_WITHOUT_INTEREST_INDIVIDUAL)
                {
                    numberOfMonths -= MONTHS_WITHOUT_INTEREST_INDIVIDUAL;
                }
            }
            else
            {
                if (numberOfMonths >= MONTHS_WITHOUT_INTEREST_COMPANY)
                {
                    numberOfMonths -= MONTHS_WITHOUT_INTEREST_COMPANY;
                }
            }

            double interestAmount = numberOfMonths * this.InterestRate;
            return interestAmount;
        }

        public void MakeDeposit(double depositAmount)
        {
            this.Balance += depositAmount;
        }
    }
}
