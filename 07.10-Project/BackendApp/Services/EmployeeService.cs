using BackendApp.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BackendApp.Interfaces;
using System.Linq;

namespace BackendApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DatabaseContext _dbContext;
        public EmployeeService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
            if (!_dbContext.Employees.Any())
            {
                _dbContext.Employees.Add(new Employee { FirstName = "Анатолій", Surname = "Володимирович", LastName = "Хитрий", Post = "Директор", Salary = 30000, PriorSalary = 3000 });
                _dbContext.Employees.Add(new Employee { FirstName = "Андрій", Surname = "Антонович", LastName = "Ступка", Post = "Провізор", Salary = 7000, PriorSalary = 1500 });
                _dbContext.Employees.Add(new Employee { FirstName = "Олег", Surname = "Артемович", LastName = "Суслік", Post = "Кладовщик", Salary = 5000, PriorSalary = 500 });
                _dbContext.Employees.Add(new Employee { FirstName = "Максим", Surname = "Іванович", LastName = "Рудьковський", Post = "Фармацевт", Salary = 5000, PriorSalary = 500 });
                _dbContext.Employees.Add(new Employee { FirstName = "Ірина", Surname = "Михайлівна", LastName = "Макар", Post = "Провізор", Salary = 7000, PriorSalary = 1500 });
                _dbContext.Employees.Add(new Employee { FirstName = "Юлія", Surname = "Борисівна", LastName = "Гаран", Post = "Фармацевт", Salary = 7000, PriorSalary = 1500 });
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<Employee> GetEmployee()
        {
            var employee = _dbContext.Employees.ToList();
            return employee;
        }
        public Employee GetEmployeeById(int id)
        {
            var employee = _dbContext.Employees.FirstOrDefault(x => x.Id == id);
            return employee;
        }

        public Employee AddEmployee(Employee employee)
        {
            if (employee != null)
            {
                _dbContext.Employees.Add(employee);
                _dbContext.SaveChanges();
                return employee;
            }
            return null;
        }
        public Employee UpdateEmployee(Employee employee)
        {
            _dbContext.Entry(employee).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return employee;
        }
        public Employee DeleteEmployee(int id)
        {
            var employee = _dbContext.Employees.FirstOrDefault(x => x.Id == id);
            _dbContext.Entry(employee).State = EntityState.Deleted;
            _dbContext.SaveChanges();
            return employee;
        }

        /*        public async Task CreateEmployee(Employee employee)
                {
                    await _dbContext.Employees.AddAsync(employee);
                    await _dbContext.SaveChangesAsync();
                }

                public async Task<List<Employee>> ReadEmployees()
                {
                    return await _dbContext.Employees.ToListAsync();
                }

                public async Task<Employee> ReadEmployee(int id)
                {
                    var employee = await _dbContext.Employees.FindAsync(id);
                    if (employee == null)
                    {
                        return NotFound();
                    }
                    return employee;
                }

                public async Task UpdateEmployee(Employee employee)
                {
                    _dbContext.Entry(employee).State = EntityState.Modified;
                    await _dbContext.SaveChangesAsync();
                }

                public async Task<Employee> DeleteEmployee(int id)
                {
                    var employee = await _dbContext.Employees.FindAsync(id);
                    if (employee == null)
                    {
                        return NotFound();
                    }
                    _dbContext.Employees.Remove(employee);
                    await _dbContext.SaveChangesAsync();
                    return employee;
                }*/

    }
}
