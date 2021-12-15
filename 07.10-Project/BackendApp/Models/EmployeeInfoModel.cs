using System; 

namespace BackendApp.Models
{
    public class EmployeeInfo
    {
        public int Id { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }  
    }
}
