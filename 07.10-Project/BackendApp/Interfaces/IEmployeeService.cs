using BackendApp.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BackendApp.Interfaces
{
    public interface IEmployeeService
    {
        public IEnumerable<Employee> GetEmployee();
        public Employee GetEmployeeById(int id);
        public Employee AddEmployee(Employee employee);
        public Employee UpdateEmployee(Employee employee);
        public Employee DeleteEmployee(int id);

        /*        public Task CreateEmployee(Employee employee);
                public Task <List<Employee>> ReadEmployees();
                public Task<Employee> ReadEmployee(int id);
                public Task UpdateEmployee(Employee employee);
                public Task<Employee> DeleteEmployee(int id);*/
    }
}
