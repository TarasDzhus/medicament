import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { EmployeeInfo } from '../models/employee-info.model';

@Injectable({
 providedIn: 'root'
})
export class EmployeeInfoService {

  readonly APIUrl = "http://localhost:5000/api";
  constructor(private http: HttpClient) { }

  getEmployeeInfoList() {
    return this.http.get<EmployeeInfo[]>(this.APIUrl + '/EmployeeInfo');
  }
  addEmployeeInfo(val: EmployeeInfo) {
    return this.http.post(this.APIUrl + '/EmployeeInfo', val);
  }
  updateEmployeeInfo(val: EmployeeInfo) {
    return this.http.put(this.APIUrl + '/EmployeeInfo', val);
  }
  deleteEmployeeInfo(id: number) {
    return this.http.delete(this.APIUrl + '/EmployeeInfo/' + id);
  }
}
