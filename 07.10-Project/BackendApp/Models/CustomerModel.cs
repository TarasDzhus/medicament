using System; 
using System.Collections.Generic;

namespace BackendApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public DateTime? CreationTime { get; set; }

        public List<Order> Orders { get; set; }
    }
}

