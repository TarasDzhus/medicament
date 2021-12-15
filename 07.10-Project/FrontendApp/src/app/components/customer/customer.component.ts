import { Component, Input, OnInit } from '@angular/core';
import { Customer } from 'src/app/models/customer.model';
import { CustomerService } from "src/app/services/customer.service";

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html'
  //styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {

  @Input() input: Customer;
  public customerList: Customer[];
  public modalTitle: string;
  activateAddEditCusCom: boolean = false;
  public customer: Customer;

  constructor(private customerService: CustomerService) { }

  ngOnInit(): void {
    this.refreshСustomerList();
  }

  refreshСustomerList() {
    this.customerService.getСustomerList().subscribe(data => {
      this.customerList = data;
      console.log(data);
    });
  }

  addCustomer() {
    this.customerService.addCustomer(this.customer).subscribe(res => {
      alert(res.toString());
    })
  }

  updateCustomer() {
    this.customerService.updateCustomer(this.customer).subscribe(res => {
      alert(res.toString());
    })
  }

  editCustomer(item: any) {
    this.customer = item;
    this.activateAddEditCusCom = true;
    this.modalTitle = "Update Сustomer";
  }

  deleteClick(item: any) {
    if (confirm('Are you sure??')) {
      this.customerService.deleteCustomer(item.Id).subscribe(data => {
        alert(data.toString());
        this.refreshСustomerList();
      })
    }
  }

  closeClick() {
    this.activateAddEditCusCom = false;
    this.refreshСustomerList();
  }

}
