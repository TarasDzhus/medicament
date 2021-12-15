import { EmployeeInfo } from "./employee-info.model";
import { Order } from "./order.model";

export interface Employee {
  id: number;
  firstName: string;
  surname: string;
  lastName: string;
  post: string;
  salary: number;
  priorSalary: number;
  employeeInfo: EmployeeInfo;
  orders: Order[];
}
