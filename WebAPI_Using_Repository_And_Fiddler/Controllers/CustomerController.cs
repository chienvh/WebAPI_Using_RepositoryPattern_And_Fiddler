using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Using_Repository_And_Fiddler.Models;

namespace WebAPI_Using_Repository_And_Fiddler.Controllers
{
    public class CustomerController : ApiController
    {
        // GET: api/Customer
        public List<Customer> Get()
        {
            return CustomerRepository.GetAllCustomers();
        }

        // GET: api/Customer/5
        public Customer Get(int id)
        {
            return CustomerRepository.GetCustomer(id);
        }

        // POST: api/Customer
        public void Post([FromBody]Customer customer)
        {
            CustomerRepository.InsertCustomer(customer);
        }

        // PUT: api/Customer/5
        public void Put(int id, [FromBody]Customer customer)
        {
            CustomerRepository.UpdateCustomer(customer);
        }

        // DELETE: api/Customer/5
        public void Delete(int id)
        {
            CustomerRepository.DeleteCustomer(id);
        }
    }
}
