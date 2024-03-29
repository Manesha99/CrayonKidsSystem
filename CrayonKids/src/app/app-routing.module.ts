import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router'
import { AddEmployeeDetailsComponent } from './employee/add-employee-details/add-employee-details.component';
import { EmployeeComponent } from './employee/employee.component';
import { EmployeesResolverService } from './services/employees-resolver.service';
import { EmployeeTypeComponent } from './employee/employee-type/employee-type.component';
import { AssessmentsComponent } from './assessments/assessments.component';
import { AllergyComponent } from './allergy/allergy.component';
import { AddAllergyComponent } from './allergy/add-allergy/add-allergy.component';
import { UpdateEmployeeDetailsComponent } from './employee/update-employee-details/update-employee-details.component';
import { AddAssessmentsComponent } from './assessments/add-assessments/add-assessments.component';
import { LoginComponent } from './login/login.component';
import { SchoolComponent } from './school/school.component';
import { AddSchoolComponent } from './school/add-school/add-school.component';
import { UpdateSchoolComponent } from './school/update-school/update-school.component';
import { StudentComponent } from './student/student.component';
import { AddStudentComponent } from './student/add-student/add-student.component';
import { UpdateStudentComponent } from './student/update-student/update-student.component';
import { AddSupplierComponent } from './supplier/add-supplier/add-supplier.component';
import { SupplierComponent } from './supplier/supplier.component';
import { EmergencyComponent } from './emergency/emergency.component';
import { AddEmergencyComponent } from './emergency/add-emergency/add-emergency.component';

const routes: Routes = [
  {path: 'assessmentList', component:AssessmentsComponent},
  {path: 'updateEmployee/:id', component:UpdateEmployeeDetailsComponent},
  {path: 'addAssessment', component:AddAssessmentsComponent},
  {path: 'employeelist', component: EmployeeComponent, resolve: {employees:EmployeesResolverService}},
  {path: 'addemployeedetails', component: AddEmployeeDetailsComponent},
  {path: 'employeeType', component: EmployeeTypeComponent},
  {path: 'allergylist', component: AllergyComponent},
  {path: 'addallergydetails', component: AddAllergyComponent},
  {path: 'login', component: LoginComponent},
  {path: 'schoollist', component: SchoolComponent},
  {path: 'addSchoolName', component: AddSchoolComponent},
  {path: 'updateSchool', component:UpdateSchoolComponent},
  {path: 'studentlist', component: StudentComponent},
  {path: 'addStudentName', component: AddStudentComponent},
  {path: 'updateStudent', component:UpdateStudentComponent},
  {path: 'supplierlist', component: SupplierComponent},
  {path: 'addSupplier', component: AddSupplierComponent},
  {path: 'emergencylist', component: EmergencyComponent},
  {path: 'addEmergency', component: AddEmergencyComponent},


  {path: '', redirectTo: '/login', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingComponents = [ AddEmployeeDetailsComponent,EmployeeComponent]
