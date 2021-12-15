using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? OrderDate { get; set; }
        public int MedicamentId { get; set; }
        public int Qty { get; set; }
        [Column(TypeName = "decimal")]
        public decimal Price { get; set; }
        public  Customer Customer { get; set; }
        public  Employee Employee { get; set; }

        public Order()
        {
            MedicamentOrders = new List<MedicamentOrderModel>();
        }
        public List<MedicamentOrderModel> MedicamentOrders { get; set; }
    }
}
