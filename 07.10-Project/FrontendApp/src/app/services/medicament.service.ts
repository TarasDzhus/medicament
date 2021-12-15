import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Medicament } from '../models/medicament.model';

@Injectable({
 providedIn: 'root'
})
export class MedicamentService {

  readonly APIUrl = "http://localhost:5000/api";
  constructor(private http: HttpClient) { }

  getMedicamentList() {
    return this.http.get<Medicament[]>(this.APIUrl + '/Order');
  }
  addMedicament(val: Medicament) {
    return this.http.post(this.APIUrl + '/Order', val);
  }
  updateMedicament(val: Medicament) {
    return this.http.put(this.APIUrl + '/Order', val);
  }
  deleteMedicament(id: number) {
    return this.http.delete(this.APIUrl + '/Order/' + id);
  }
}
