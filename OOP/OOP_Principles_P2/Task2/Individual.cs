namespace Task2
{
    using System;
    using System.Collections.Generic;

    public class Individual : Customer
    {
        public Individual() : base()
        {
            this.PersonalIDNumer = default(int);
        }

        public Individual(string name, List<BankAccount> customerBankAccounts, int personalIDNumer) : base(name,
            customerBankAccounts)
        {
            this.PersonalIDNumer = personalIDNumer;
        }

        public int PersonalIDNumer { get; set; } 
    }
}
