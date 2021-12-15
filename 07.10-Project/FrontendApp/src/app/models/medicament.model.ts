import { MedicamentOrder } from "./medicament-order.model"

export interface Medicament {

  id: number;
  name: string;
  medicamentQty: number;

 // medicamentOrders: MedicamentOrder[];
 // public Medicament() { medicamentOrders }
  //      {  MedicamentOrders = new List<MedicamentOrderModel>();   }
  //public List < MedicamentOrderModel > MedicamentOrders { get; set; }
}
