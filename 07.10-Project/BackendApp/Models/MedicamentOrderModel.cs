 
namespace BackendApp.Models
{
    public class MedicamentOrderModel
    {
        public int MedicamentId { get; set; }
        public Medicament Medicament { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
