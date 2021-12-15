import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Customer } from '../models/customer.model';

@Injectable({
 providedIn: 'root'
})
export class CustomerService {

  readonly APIUrl = "http://localhost:5000/api";
  constructor(private http: HttpClient) {}

  getСustomerList() {
    return this.http.get<Customer[]>(this.APIUrl + '/Customer');
  }

  addCustomer(val: Customer) {
    return this.http.post(this.APIUrl + '/Customer', val);
  }
  updateCustomer(val: Customer) {
    return this.http.put(this.APIUrl + '/Customer', val);
  }
  deleteCustomer(id: number) {
    return this.http.delete(this.APIUrl + '/Customer/' + id);
  }
}
