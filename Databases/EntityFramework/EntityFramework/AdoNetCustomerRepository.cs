using System;
using System.Data.Entity.Validation;
using System.Linq;

namespace EntityFramework
{
    public class AdoNetCustomerRepository : ICustomerRepository
    { 
        public int Insert(Customer customer)
        {
            var dbContext = new NorthwindDbContext();

            try
            {
                dbContext.Customers.Add(customer);
                dbContext.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }


            var addedCustomer = dbContext.Customers
                .Where(c => c.CustomerID == customer.CustomerID)
                .First();

            return int.Parse(addedCustomer.CustomerID);
        }

        public int Update(Customer customer)
        {
            var dbContext = new NorthwindDbContext();

            var customerToBeUpdated = dbContext.Customers
                .Where(c => c.CustomerID == customer.CustomerID)
                .First();

            customerToBeUpdated.ContactName = customer.ContactName;
            customerToBeUpdated.Address = customer.Address;
            customerToBeUpdated.City = customer.City;
            customerToBeUpdated.ContactTitle = customer.ContactTitle;
            customerToBeUpdated.CompanyName = customer.CompanyName;
            customerToBeUpdated.Country = customer.Country;
            customerToBeUpdated.CustomerDemographics = customer.CustomerDemographics;
            customerToBeUpdated.Fax = customer.Fax;
            customerToBeUpdated.Orders = customer.Orders;
            customerToBeUpdated.Phone = customer.Phone;
            customerToBeUpdated.PostalCode = customer.PostalCode;
            customerToBeUpdated.Region = customer.Region;

            dbContext.SaveChanges();
            return int.Parse(customerToBeUpdated.CustomerID);
        }

        public int Delete(int customerId)
        {
            var dbContext = new NorthwindDbContext();
            
            Customer customerToBeDeleted = dbContext.Customers
                                              .Where(customer => customer.CustomerID == customerId.ToString())
                                              .SingleOrDefault();
            try
            {
                dbContext.Customers.Remove(customerToBeDeleted);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            dbContext.SaveChanges();
            return int.Parse(customerToBeDeleted.CustomerID);
        }
    }
}
