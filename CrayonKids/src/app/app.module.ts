import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {MatTableModule} from '@angular/material/table';
//import { AddEmployeeTypeComponent } from './add-employee-type/add-employee-type.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AddEmployeeDetailsComponent } from './add-employee-details/add-employee-details.component';
import { FormsModule } from '@angular/forms';
import { EmployeeComponent } from './employee/employee.component';
import { EmployeeService } from './services/employee.service';


@NgModule({
  declarations: [
    AppComponent,
    //AddEmployeeTypeComponent,
    AddEmployeeDetailsComponent,
    EmployeeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatTableModule,
    BrowserAnimationsModule
  ],
  providers: [EmployeeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
