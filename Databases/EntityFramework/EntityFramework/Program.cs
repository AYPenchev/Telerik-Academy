namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;

    public class Program
    {
        //Task 3
        public static IEnumerable<Customer> SelectOrdersMadeIn1997AndShippedToCanada()
        {
            var entities = new List<Customer>();

            var orderDateYear = 1997;
            var shipCountry = "Canada";

            var dbContext = new NorthwindDbContext();

            entities = (from customer in dbContext.Customers
                        join order in dbContext.Orders on customer.CustomerID equals order.CustomerID
                        where order.OrderDate.Value.Year == orderDateYear && order.ShipCountry == shipCountry
                        select customer).Distinct().ToList();

            return entities;
        }

        //Task 4
        public static void RunStoredProc()
        {
            SqlConnection connectNW = new SqlConnection("server=localhost;integrated security=true;" + "database=NW");
            connectNW.Open();

            SqlCommand cmdCustomers = new SqlCommand("usp_SelectOrdersMadeIn1997AndShippedToCanada", connectNW);

            cmdCustomers.CommandType = CommandType.StoredProcedure;

            SqlDataReader execStoredProcedure = cmdCustomers.ExecuteReader();

            while (execStoredProcedure.Read())
            {
                Console.WriteLine(execStoredProcedure["ContactName"]);
                Console.WriteLine(execStoredProcedure["Country"]);
            }
        }

        //Task 5
        public static IEnumerable<Order> SalesBySpecifiedRegionAndDatePeriod(string region, DateTime? startDate, DateTime? endDate)
        {
            var entities = new List<Order>();

            var dbContext = new NorthwindDbContext();

            entities = (from order in dbContext.Orders
                        where order.ShipRegion == region &&
                              order.OrderDate >= startDate &&
                              order.OrderDate <= endDate
                        select order).ToList();

            return entities;
        }


        public static void Main()
        {
            Customer customerNEW = new Customer();
            customerNEW.CompanyName = "Grafixoft";
            customerNEW.Country = "BG";
            customerNEW.CustomerID = "1";

            /* Task 1-2 
            AdoNetCustomerRepository entryPoint = new AdoNetCustomerRepository();
            entryPoint.Insert(customerNEW);

            int customerNEWId = int.Parse(customerNEW.CustomerID);
            entryPoint.Delete(customerNEWId);

            customerNEW.ContactName = Console.ReadLine();
            entryPoint.Update(customerNEW);
            */

            /* Task 3
            var customers = SelectOrdersMadeIn1997AndShippedToCanada();
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.ContactName} {customer.Country}");
            }
            */

            /* Task 4
            RunStoredProc();
            */

            /* Task 5
            var region = "RJ";
            var startDate = new DateTime(1997, 6, 15);
            var endDate = new DateTime(1998, 7, 1);

            var orders = SalesBySpecifiedRegionAndDatePeriod(region, startDate, endDate);

            foreach (var order in orders)
            {
                Console.WriteLine(order.OrderID);
            }
            */

            /* Task 6
            var northwindEntities = new NorthwindDbContext();
            northwindEntities.Database.CreateIfNotExists();
            Console.WriteLine("\rNumbers of customers: " + northwindEntities.Customers.Count());
            */

            /* Task 7
            var dbContextFirstConnection = new NorthwindDbContext();
            var dbContextSecondConnection = new NorthwindDbContext();

            var customer = new Customer()
            {
                CustomerID = "2",
                ContactName = "Name",
                ContactTitle = dbContextSecondConnection.Customers.First().ContactTitle,
                CompanyName = dbContextFirstConnection.Customers.First().CompanyName
            };

            dbContextSecondConnection.Customers.Add(customer);
            dbContextSecondConnection.SaveChanges();
            */

            /* Task 8 

            var northwindDbContext = new NorthwindDbContext();

            foreach (var employee in northwindDbContext.Employees.Include("Territories"))
            {
                var correspondingTerritories = employee.Territories.Select(c => c.TerritoryID);
                var correspondingTerritoriesAsString = string.Join(", ", correspondingTerritories);
                Console.WriteLine("{0} -> Territory IDs: {1}", employee.FirstName, correspondingTerritoriesAsString);
            }
            */
        }
    }
}
