namespace Task2
{
    using System.Collections.Generic;

    public class Individual : Customer
    {
        public Individual() : base()
        {
            this.PersonalIDNumer = string.Empty;
        }

        public Individual(string name, string personalIDNumer, List<BankAccount> customerBankAccounts = null) : base(name, customerBankAccounts)
        {
            this.PersonalIDNumer = personalIDNumer;
        }

        public string PersonalIDNumer { get; set; }

        public override string ToString()
        {
            string individualInformation = "Personal ID number: " + this.PersonalIDNumer + "\n" + base.ToString();
            return individualInformation; 
        }
    }
}
