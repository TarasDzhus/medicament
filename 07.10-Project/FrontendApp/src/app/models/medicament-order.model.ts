import { Medicament } from "./medicament.model";
import { Order } from "./order.model";

export interface MedicamentOrder {
  medicamentId: number;
  medicament: Medicament;

  orderId: number;
  orders: Order[];
  
}
