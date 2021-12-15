import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import {
        CustomerComponent,
        EmployeeComponent,
        EmployeeInfoComponent,
        MedicamentComponent,
        OrderComponent         } from './index';

const routes: Routes = [
  {path:'customer', component:CustomerComponent},
  {path:'employee', component:EmployeeComponent},
  {path:'employeeInfo', component:EmployeeInfoComponent},
  {path:'medicament', component:MedicamentComponent},
  {path:'order', component:OrderComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
