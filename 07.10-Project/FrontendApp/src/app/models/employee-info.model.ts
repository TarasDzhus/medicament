import { Employee } from "./employee.model";

export interface EmployeeInfo {
  id: number;
  maritalStatus: string;
  birthDate: Date;
  address: string;
  phone: string;
  employeeId: number;
  employee: Employee[];
}
