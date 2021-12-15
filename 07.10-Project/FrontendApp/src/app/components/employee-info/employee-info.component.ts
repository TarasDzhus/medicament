import { Component, Input, OnInit } from '@angular/core';
import { EmployeeInfo } from 'src/app/models/employee-info.model';
import { EmployeeInfoService } from "src/app/services/employee-info.service";

@Component({
  selector: 'app-customer',
  templateUrl: './employee-info.component.html',
  //styleUrls: ['./customer.component.css']

})
export class EmployeeInfoComponent implements OnInit {

  @Input() input: EmployeeInfo;
  public employeeInfoList: EmployeeInfo[];
  public modalTitle: string;
  activateAddEditEmpCom: boolean = false;
  public employeeInfo: EmployeeInfo;

  constructor(private employeeInfoService: EmployeeInfoService) { }

  ngOnInit(): void {
    this.refreshEmployeeInfoList();
  }

  refreshEmployeeInfoList() {
    this.employeeInfoService.getEmployeeInfoList().subscribe(data => {
      this.employeeInfoList = data;
    });
  }

  addEmployeeInfo() {
    this.employeeInfoService.addEmployeeInfo(this.employeeInfo).subscribe(res => {
      alert(res.toString());
    })
  }

  updateEmployeeInfo() {
    this.employeeInfoService.updateEmployeeInfo(this.employeeInfo).subscribe(res => {
      alert(res.toString());
    })
  }

  editEmployeeInfo(item: any) {
    this.employeeInfo = item;
    this.activateAddEditEmpCom = true;
    this.modalTitle = "Update Сustomer";
  }

  deleteClick(item: any) {
    if (confirm('Are you sure??')) {
      this.employeeInfoService.deleteEmployeeInfo(item.Id).subscribe(data => {
        alert(data.toString());
        this.refreshEmployeeInfoList();
      })
    }
  }

  closeClick() {
    this.activateAddEditEmpCom = false;
    this.refreshEmployeeInfoList();
  }

}
