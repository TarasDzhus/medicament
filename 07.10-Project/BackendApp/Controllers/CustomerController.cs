using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BackendApp.Models;
using BackendApp.Interfaces;

namespace BackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController (ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        /*[Route("[action]")]
        [Route("api/Customer/GetCustomer")]*/
        public IEnumerable<Customer> GetCustomers()
        {
            return _customerService.GetCustomers();
        }

        [HttpGet("{id}")]
        /*        [Route("[action]")]
                [Route("api/Customer/GetCustomerId")]*/
        public Customer GetCustomerId(int id)
        {
            return _customerService.GetCustomerById(id);
        }

        [HttpPost]
/*        [Route("[action]")]
        [Route("api/Customer/AddCustomer")]*/
        public Customer AddCustomer(Customer customer)
        {
            return _customerService.AddCustomer(customer);
        }
        [HttpPut]
/*        [Route("[action]")]
        [Route("api/Customer/EditCustomer")]*/
        public Customer EditCustomer(Customer customer)
        {
            return _customerService.UpdateCustomer(customer);
        }
        [HttpDelete]
/*        [Route("[action]")]
        [Route("api/Customer/DeleteCustomer")]*/
        public Customer DeleteCustomer(int id)
        {
            return _customerService.DeleteCustomer(id);
        }

        /*        
                // GET: api/Customers
                [HttpGet]
                public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
                {
                     return await _customerService.ReadCustomers();
                }
                // GET: api/Customers/5
                [HttpGet("{id}")]
                public async Task<ActionResult<Customer>> GetCustomer(int id)
                {
                     return await _customerService.ReadCustomer(id);
                }

                // PUT: api/Customers/5
                // To protect from overposting attacks, enable the specific properties you want to bind to, for
                // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
                [HttpPut("{id}")]
                public async Task<ActionResult<Customer>> PutCustomer(int id, Customer customer)
                {
                    if (ModelState.IsValid)
                    {
                        await _customerService.UpdateCustomer (customer); 
                        return CreatedAtAction(nameof(PutCustomer), new { id = customer.Id }, customer);
                    }
                    return BadRequest(ModelState);
                }
                // POST: api/Customers
                // To protect from overposting attacks, enable the specific properties you want to bind to, for
                // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
                [HttpPost]
                public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
                {
                    if (ModelState.IsValid)
                    {
                        await _customerService.CreateCustomer(customer);
                        return CreatedAtAction(nameof(PostCustomer), new { id = customer.Id }, customer);
                    }
                    return BadRequest(ModelState);
                }

                // DELETE: api/Customers/5
                [HttpDelete("{id}")]
                public async Task<ActionResult<Customer>> DeleteCustomer(int id)
                {
                    return await _customerService.DeleteCustomer(id);

                }*/

    }
}





/*using System;
using System.Collections.Generic; 
using System.Linq;
using System.Threading.Tasks;
using BackendApp.Models;

namespace BackendApp
{
    public class OperationsCRUD
    {
        public static void Create(Customer Customer)
        {
            using BackendContext db = new BackendContext();
            db.Customer.Add(Customer);
            db.SaveChanges();
        }
        public static Customer Read(int id)
        {
            using (BackendContext db = new BackendContext())
            {
                foreach (Customer Customer in db.Customer)
                {
                    if (Customer.Id == id)
                        return Customer;
                }
            }
            return null;
        }
        public static void Update(Customer Customer)
        {
            using BackendContext db = new BackendContext();
            db.Customer.Update(Customer);
            db.SaveChanges();
        }
        public static void Delete(Customer Customer)
        {
            using BackendContext db = new BackendContext();
            db.Customer.Remove(Customer);
            db.SaveChanges();
        }
    }
}
*/