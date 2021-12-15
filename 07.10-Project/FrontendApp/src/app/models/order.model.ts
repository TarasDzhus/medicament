import { Customer } from "./customer.model";
import { Employee } from "./employee.model";
import { MedicamentOrder } from "./medicament-order.model";

export interface Order {
    id: number;
    customerId: number;
    employeeId: number;
    orderDate: Date;
    medicamentId: number;
    qty: number;
    price: number;
    customers: Customer[];
    employee: Employee[];

   // medicamentOrders: MedicamentOrder[];
    //public Order()  { medicamentOrders }

  //     {  MedicamentOrders = new List<MedicamentOrderModel>();  }
  // public List < MedicamentOrderModel > MedicamentOrders { get; set; }

}
