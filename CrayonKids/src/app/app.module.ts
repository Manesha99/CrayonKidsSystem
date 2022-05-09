import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {MatTableModule} from '@angular/material/table';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AddEmployeeDetailsComponent } from './employee/add-employee-details/add-employee-details.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EmployeeComponent } from './employee/employee.component';
import { EmployeeService } from './services/employee.service';
import { EmployeeTypeComponent } from './employee/employee-type/employee-type.component';
import { AssessmentsComponent } from './assessments/assessments.component';
import { AddAssessmentsComponent } from './assessments/add-assessments/add-assessments.component';
<<<<<<< HEAD
import { AllergyComponent } from './allergy/allergy.component';
import { AddAllergyComponent } from './allergy/add-allergy/add-allergy.component';
=======
import { UpdateEmployeeDetailsComponent } from './employee/update-employee-details/update-employee-details.component';
>>>>>>> fdb0b1ea633b626cf091002820f20c664f36454f



@NgModule({
  declarations: [
    AppComponent,
    AddEmployeeDetailsComponent,
    EmployeeComponent,
    EmployeeTypeComponent,
    AssessmentsComponent,
    AddAssessmentsComponent,
<<<<<<< HEAD
    AllergyComponent,
    AddAllergyComponent,
=======
    UpdateEmployeeDetailsComponent,
>>>>>>> fdb0b1ea633b626cf091002820f20c664f36454f

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatTableModule,
    BrowserAnimationsModule,
    ReactiveFormsModule
  ],
  providers: [EmployeeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
