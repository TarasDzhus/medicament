import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Employee } from '../models/employee.model';

@Injectable({
 providedIn: 'root'
})
export class EmployeeService {

  readonly APIUrl = "http://localhost:5000/api";
  constructor(private http: HttpClient) { }

  getEmployeeList() {
    return this.http.get<Employee[]>(this.APIUrl + '/Employee');
  }
  addEmployee(val: Employee) {
    return this.http.post(this.APIUrl + '/Employee', val);
  }
  updateEmployee(val: Employee) {
    return this.http.put(this.APIUrl + '/Employee', val);
  }
  deleteEmployee(id: number) {
    return this.http.delete(this.APIUrl + '/Employee/' + id);
  }
}
