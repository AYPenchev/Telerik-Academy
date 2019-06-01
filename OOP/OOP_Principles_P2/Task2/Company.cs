namespace Task2
{
    using System;
    using System.Collections.Generic;

    public class Company : Customer
    {
        public Company() : base()
        {
            this.CompanyRegistrationNumber = default(int);
        }

        public Company(string name, List<BankAccount> customerBankAccounts, int companyRegistrationNumber) : base(name,
            customerBankAccounts)
        {
            this.CompanyRegistrationNumber = companyRegistrationNumber;
        }

        public int CompanyRegistrationNumber { get; set; }
    }
}
