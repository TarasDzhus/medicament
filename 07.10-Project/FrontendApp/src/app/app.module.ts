import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from "@angular/common/http";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";

import { AppComponent } from './app.component';

import {
  CustomerComponent,
  EmployeeComponent,
  EmployeeInfoComponent,
  MedicamentComponent,
  OrderComponent,

  CustomerService,
  EmployeeService,
  EmployeeInfoService,
  MedicamentService,
  OrderService,
} from './index';

@NgModule({
  declarations: [
    AppComponent,
    CustomerComponent,
    EmployeeComponent,
    EmployeeInfoComponent,
    MedicamentComponent,
    OrderComponent
  ],
  imports: [
    CommonModule,
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
  ],

  providers: [ CustomerService, EmployeeService, EmployeeInfoService, MedicamentService, OrderService ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }
