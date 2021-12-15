import { Order } from "./order.model";

export interface Customer {
  id: number;
  firstName: string;
  surname: string;
  lastName: string;
  address: string;
  city: string;
  phone: string;
  creationTime: Date;
  orders: Order[];
}
