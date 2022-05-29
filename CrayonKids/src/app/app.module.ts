import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AddEmployeeDetailsComponent } from './employee/add-employee-details/add-employee-details.component';
import { UpdateEmployeeDetailsComponent } from './employee/update-employee-details/update-employee-details.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { EmployeeComponent } from './employee/employee.component';
import { EmployeeService } from './services/employee.service';
import { EmployeeTypeComponent } from './employee/employee-type/employee-type.component';
import { AssessmentsComponent } from './assessments/assessments.component';
import { AddAssessmentsComponent } from './assessments/add-assessments/add-assessments.component';
import { AllergyComponent } from './allergy/allergy.component';
import { AddAllergyComponent } from './allergy/add-allergy/add-allergy.component';
import { LoginComponent } from './login/login.component';
//Materials
import {MatTableModule} from '@angular/material/table';
import { MatAutocompleteModule} from '@angular/material/autocomplete';
  import {MatButtonModule} from '@angular/material/button';
  import {MatCheckboxModule} from '@angular/material/checkbox';
  import {MatDatepickerModule} from '@angular/material/datepicker';
  import {MatInputModule} from '@angular/material/input';
  import {MatRadioModule} from '@angular/material/radio';
  import {MatSelectModule} from '@angular/material/select';
  import {MatCardModule} from '@angular/material/card';
  import {MatSlideToggleModule} from '@angular/material/slide-toggle';
  import {MatSliderModule} from '@angular/material/slider';
  import {MatIconModule} from '@angular/material/icon';
  import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
  import {MatExpansionModule} from '@angular/material/expansion';
  import { MatNativeDateModule } from '@angular/material/core';

   
   



@NgModule({
  declarations: [
    AppComponent,
    AddEmployeeDetailsComponent,
    EmployeeComponent,
    EmployeeTypeComponent,
    AssessmentsComponent,
    AddAssessmentsComponent,
    AllergyComponent,
    AddAllergyComponent,
    LoginComponent,
    UpdateEmployeeDetailsComponent
  

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatTableModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    MatCardModule,MatDatepickerModule,MatButtonModule,MatSliderModule,MatSlideToggleModule,MatSelectModule,MatRadioModule,MatInputModule,MatCheckboxModule,MatAutocompleteModule,MatIconModule,MatProgressSpinnerModule,MatExpansionModule,  MatNativeDateModule
  ],
  providers: [EmployeeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
