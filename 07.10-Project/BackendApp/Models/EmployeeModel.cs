using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public string Post { get; set; }
        [Column(TypeName ="decimal")]
        public decimal Salary { get; set; }
        [Column(TypeName = "decimal")]
        public decimal? PriorSalary { get; set; }
        public EmployeeInfo EmployeeInfo { get; set; }

        public List <Order> Orders { get; set; }
    }
}
