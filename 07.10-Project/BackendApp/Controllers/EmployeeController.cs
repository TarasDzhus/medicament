using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendApp.Models;
using BackendApp.Interfaces;

namespace BackendApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
            public EmployeeController(IEmployeeService employeeService)
            {
            _employeeService = employeeService;
            }

            [HttpGet]
            [Route("[action]")]
            [Route("api/Employee/GetEmployee")]
            public IEnumerable<Employee> GetEmployee()
            {
                return _employeeService.GetEmployee();
            }

            [HttpGet]
            [Route("[action]")]
            [Route("api/Employee/GetEmployeeId")]
            public Employee GetEmployeeId(int id)
            {
                return _employeeService.GetEmployeeById(id);
            }

            [HttpPost]
            [Route("[action]")]
            [Route("api/Employee/AddEmployee")]
            public Employee AddEmployee(Employee employee)
            {
                return _employeeService.AddEmployee(employee);
            }
            [HttpPut]
            [Route("[action]")]
            [Route("api/Employee/EditEmployee")]
            public Employee EditEmployee(Employee employee)
            {
                return _employeeService.UpdateEmployee(employee);
            }
            [HttpDelete]
            [Route("[action]")]
            [Route("api/Medicament/DeleteMedicament")]
            public Employee DeleteEmployee(int id)
            {
                return _employeeService.DeleteEmployee(id);
            }

            /*
            // GET: api/Employees
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
            {
                return await _context.Employees.ToListAsync();
            }

            // GET: api/Employees/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Employee>> GetEmployee(int id)
            {
                var employee = await _context.Employees.FindAsync(id);

                if (employee == null)
                {
                    return NotFound();
                }

                return employee;
            }

            // PUT: api/Employees/5
            // To protect from overposting attacks, enable the specific properties you want to bind to, for
            // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
            [HttpPut("{id}")]
            public async Task<IActionResult> PutEmployee(int id, Employee employee)
            {
                if (id != employee.Id)
                {
                    return BadRequest();
                }

                _context.Entry(employee).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return NoContent();
            }

            // POST: api/Employees
            // To protect from overposting attacks, enable the specific properties you want to bind to, for
            // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
            [HttpPost]
            public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
            {
                _context.Employees.Add(employee);
                await _context.SaveChangesAsync();

                //return CreatedAtAction("GetEmployee", new { id = employee.Id }, employee);
                return CreatedAtAction(nameof(GetEmployee), new { id = employee.Id }, employee);
            }

            // DELETE: api/Employees/5
            [HttpDelete("{id}")]
            public async Task<ActionResult<Employee>> DeleteEmployee(int id)
            {
                var employee = await _context.Employees.FindAsync(id);
                if (employee == null)
                {
                    return NotFound();
                }

                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();

                return employee;
            }

            private bool EmployeeExists(int id)
            {
                return _context.Employees.Any(e => e.Id == id);
            }*/
        }
}
