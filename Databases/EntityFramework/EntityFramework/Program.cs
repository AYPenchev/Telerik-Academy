namespace EntityFramework
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Customer customerNEW = new Customer();
            customerNEW.CompanyName = "Grafixoft";
            customerNEW.Country = "BG";
            customerNEW.CustomerID = "1";

            AdoNetCustomerRepository entryPoint = new AdoNetCustomerRepository();
            //entryPoint.Insert(customerNEW);
            int customerNEWId = int.Parse(customerNEW.CustomerID);
            entryPoint.Delete(customerNEWId);
            
        }
    }
}
