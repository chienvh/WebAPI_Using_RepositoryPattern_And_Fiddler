using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Using_Repository_And_Fiddler.Models
{
    public class CustomerRepository
    {
        /*Go ahead to create some basic functions:
         - GetAllCustomers() - Get the list of customers
         - GetCustomer(int id) - Get the customer info by id
         - InsertCustomer (Customer newCustomer) - Create a new customer
         - UpdateCustomer (Customer oldCustomer) - Update the info for existing customer
         - DeleteCustomer (int id) - Delete a specific customer by id*/

        private static ChienVHDbEntities dbContext = new ChienVHDbEntities();

        public static List<Customer> GetAllCustomers()
        {
            var query = from Customer in dbContext.Customers
                        select Customer;
            return query.ToList();
        }

        public static Customer GetCustomer(int id)
        {
            var query = (from Customer in dbContext.Customers
                         where Customer.id == id
                         select Customer).SingleOrDefault();
            return query;
        }

        public static void InsertCustomer(Customer newCustomer)
        {
            dbContext.Customers.Add(newCustomer);
            dbContext.SaveChanges();
        }

        public static void UpdateCustomer(Customer oldCustomer)
        {
            var query = (from Customer in dbContext.Customers
                         where Customer.id == oldCustomer.id
                         select Customer).SingleOrDefault();
            query.id = oldCustomer.id;
            query.name = oldCustomer.name;
            query.address = oldCustomer.address;
            query.age = oldCustomer.age;

            dbContext.SaveChanges();
        }

        public static void DeleteCustomer(int id)
        {
            var query = (from Customer in dbContext.Customers
                         where Customer.id == id
                         select Customer).SingleOrDefault();
            dbContext.Customers.Remove(query);

            dbContext.SaveChanges();
        }
    }
}