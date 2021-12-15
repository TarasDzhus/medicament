using BackendApp.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BackendApp.Interfaces
{
    public interface ICustomerService
    {
        public IEnumerable<Customer> GetCustomers();
        public Customer GetCustomerById(int id);
        public Customer AddCustomer(Customer customer);
        public Customer UpdateCustomer(Customer customer);
        public Customer DeleteCustomer(int id);

        /*        public Task CreateCustomer(Customer customer);
                public Task <List<Customer>> ReadCustomers();
                public Task<Customer> ReadCustomer(int id);
                public Task UpdateCustomer(Customer customer);
                public Task<Customer> DeleteCustomer(int id);*/
    }
}
