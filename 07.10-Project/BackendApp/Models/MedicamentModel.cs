using System.Collections.Generic;
 
namespace BackendApp.Models
{
    public class Medicament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MedicamentQty { get; set; }

        public Medicament()
        {
            MedicamentOrders = new List<MedicamentOrderModel>();
        }
        public List<MedicamentOrderModel> MedicamentOrders { get; set; }
}
}
