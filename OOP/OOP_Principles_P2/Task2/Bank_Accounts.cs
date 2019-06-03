using System.Linq;

namespace Task2
{
    using System;
    using System.Collections.Generic;

    class BankAccounts
    {
        static void Main()
        {
            Bank raiffeisenBank = new Bank();
            Deposit rbbDepositAccount = new Deposit();
            Loan rbbLoanAccount = new Loan();
            Mortgage rbbMortgageAccount = new Mortgage();
            
            //Individual
            Individual firsIndividualCustomer = new Individual("Ivan Petrov", "3232344565");

            Deposit firstIndividualDeposit = new Deposit(firsIndividualCustomer, 1.5);
            Mortgage firstIndividualMortgage = new Mortgage(firsIndividualCustomer, 2.5, 2000);

            List<BankAccount> firstIndividualAccounts = new List<BankAccount>()
            {
                firstIndividualDeposit,
                firstIndividualMortgage
            };

            firsIndividualCustomer.CustomerBankAccounts = firstIndividualAccounts;

            Console.WriteLine(firsIndividualCustomer.ToString());

            firstIndividualDeposit.MakeDeposit(2000);
            Console.WriteLine(firsIndividualCustomer.ToString());

            firstIndividualDeposit.MakeDeposit(10000);
            Console.WriteLine(firsIndividualCustomer.ToString());

            firstIndividualDeposit.Withdraw(3000);
            Console.WriteLine(firsIndividualCustomer.ToString());

            //Company
            Company telerik = new Company("Telerik", 234);

            Loan telerikLoan = new Loan(telerik, 2.34, 5000);

            List<BankAccount> telerikAccounts = new List<BankAccount>()
            {
                telerikLoan
            };

            telerik.CustomerBankAccounts = telerikAccounts;
        }
    }
}
