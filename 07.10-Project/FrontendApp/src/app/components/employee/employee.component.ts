import { Component, Input, OnInit } from '@angular/core';
import { Employee } from 'src/app/models/employee.model';
import { EmployeeService } from "src/app/services/employee.service";


@Component({
  selector: 'app-customer',
  templateUrl: './employee.component.html',
  //styleUrls: ['./customer.component.css']

})
export class EmployeeComponent implements OnInit {

  @Input() input: Employee;
  public employeeList: Employee[];
  public modalTitle: string;
  activateAddEditEmpCom: boolean = false;
  public employee: Employee;

  constructor(private employeeService: EmployeeService) { }

  ngOnInit(): void {
    this.refreshEmployeeList();
  }

  refreshEmployeeList() {
    this.employeeService.getEmployeeList().subscribe(data => {
      this.employeeList = data;
    });
  }

  addEmployee() {
    this.employeeService.addEmployee(this.employee).subscribe(res => {
      alert(res.toString());
    })
  }

  updateEmployee() {
    this.employeeService.updateEmployee(this.employee).subscribe(res => {
      alert(res.toString());
    })
  }

  editEmployee(item: any) {
    this.employee = item;
    this.activateAddEditEmpCom = true;
    this.modalTitle = "Update Сustomer";
  }

  deleteClick(item: any) {
    if (confirm('Are you sure??')) {
      this.employeeService.deleteEmployee(item.Id).subscribe(data => {
        alert(data.toString());
        this.refreshEmployeeList();
      })
    }
  }

  closeClick() {
    this.activateAddEditEmpCom = false;
    this.refreshEmployeeList();
  }

}
