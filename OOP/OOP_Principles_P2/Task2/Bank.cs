namespace Task2
{
    using System.Collections.Generic;

    public class Bank
    {
        public Bank()
        {
            this.AccountTypes = new List<BankAccount>();
        }

        public Bank(List<BankAccount> accountTypes)
        {
            this.AccountTypes = accountTypes;
        }

        public List<BankAccount> AccountTypes { get; set; }
    }
}
