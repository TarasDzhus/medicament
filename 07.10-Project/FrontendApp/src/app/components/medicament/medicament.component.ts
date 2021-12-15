import { Component, Input, OnInit } from '@angular/core';
import { Medicament } from 'src/app/models/medicament.model';
import { MedicamentService } from "src/app/services/medicament.service";

@Component({
  selector: 'app-customer',
  templateUrl: './medicament.component.html',
  //styleUrls: ['./customer.component.css']

})
export class MedicamentComponent implements OnInit {

  @Input() input: Medicament;
  public medicamentList: Medicament[];
  public modalTitle: string;
  activateAddEditMedCom: boolean = false;
  public medicament: Medicament;

  constructor(private medicamentService: MedicamentService) { }

  ngOnInit(): void {
    this.refreshMedicamentList();
  }

  refreshMedicamentList() {
    this.medicamentService.getMedicamentList().subscribe(data => {
      this.medicamentList = data;
    });
  }

  addMedicament() {
    this.medicamentService.addMedicament(this.medicament).subscribe(res => {
      alert(res.toString());
    })
  }

  updateMedicament() {
    this.medicamentService.updateMedicament(this.medicament).subscribe(res => {
      alert(res.toString());
    })
  }

  editMedicament(item: any) {
    this.medicament = item;
    this.activateAddEditMedCom = true;
    this.modalTitle = "Update Сustomer";
  }

  deleteClick(item: any) {
    if (confirm('Are you sure??')) {
      this.medicamentService.deleteMedicament(item.Id).subscribe(data => {
        alert(data.toString());
        this.refreshMedicamentList();
      })
    }
  }

  closeClick() {
    this.activateAddEditMedCom = false;
    this.refreshMedicamentList();
  }

}
