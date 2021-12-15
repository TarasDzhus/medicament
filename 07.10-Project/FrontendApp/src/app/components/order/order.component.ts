import { Component, Input, OnInit } from '@angular/core';
import { Order } from 'src/app/models/order.model';
import { OrderService } from "src/app/services/order.service";

@Component({
  selector: 'app-customer',
  templateUrl: './order.component.html',
  //styleUrls: ['./customer.component.css']

})
export class OrderComponent implements OnInit {

  @Input() input: Order;
  public orderList: Order[];
  public modalTitle: string;
  activateAddEditOrdCom: boolean = false;
  public order: Order;

  constructor(private orderService: OrderService) { }

  ngOnInit(): void {
    this.refreshOrderList();
  }

  refreshOrderList() {
    this.orderService.getOrderList().subscribe(data => {
      this.orderList = data;
    });
  }

  addOrder() {
    this.orderService.addOrder(this.order).subscribe(res => {
      alert(res.toString());
    })
  }

  updateOrder() {
    this.orderService.updateOrder(this.order).subscribe(res => {
      alert(res.toString());
    })
  }

  editOrder(item: any) {
    this.order = item;
    this.activateAddEditOrdCom = true;
    this.modalTitle = "Update Сustomer";
  }

  deleteClick(item: any) {
    if (confirm('Are you sure??')) {
      this.orderService.deleteOrder(item.Id).subscribe(data => {
        alert(data.toString());
        this.refreshOrderList();
      })
    }
  }

  closeClick() {
    this.activateAddEditOrdCom = false;
    this.refreshOrderList();
  }

}
