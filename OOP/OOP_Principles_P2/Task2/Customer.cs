
namespace Task2
{
    using System;
    using System.Collections.Generic;

    public abstract class Customer
    {
        protected Customer()
        {
            this.Name = string.Empty;
            this.CustomerBankAccounts = new List<BankAccount>();
        }

        protected Customer(string name, List<BankAccount> customerBankAccounts)
        {
            this.Name = name;
            this.CustomerBankAccounts = customerBankAccounts;
        }

        protected string Name { get; set; }
        protected List<BankAccount> CustomerBankAccounts { get; set; }
    }
}
