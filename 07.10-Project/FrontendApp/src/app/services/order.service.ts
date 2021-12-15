import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Order } from '../models/order.model';

@Injectable({
 providedIn: 'root'
})
export class OrderService {

  readonly APIUrl = "http://localhost:5000/api";
  constructor(private http: HttpClient) { }

  getOrderList() {
    return this.http.get<Order[]>(this.APIUrl + '/Order');
  }
  addOrder(val: Order) {
    return this.http.post(this.APIUrl + '/Order', val);
  }
  updateOrder(val: Order) {
    return this.http.put(this.APIUrl + '/Order', val);
  }
  deleteOrder(id: number) {
    return this.http.delete(this.APIUrl + '/Order/' + id);
  }
}
