import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router'
import { AddEmployeeDetailsComponent } from './employee/add-employee-details/add-employee-details.component';
import { EmployeeComponent } from './employee/employee.component';
import { EmployeesResolverService } from './services/employees-resolver.service';
import { EmployeeTypeComponent } from './employee/employee-type/employee-type.component';
import { AssessmentsComponent } from './assessments/assessments.component';
<<<<<<< HEAD
import { AllergyComponent } from './allergy/allergy.component';
import { AddAllergyComponent } from './allergy/add-allergy/add-allergy.component';
=======
import { AddAssessmentsComponent } from './assessments/add-assessments/add-assessments.component';
import { UpdateEmployeeDetailsComponent } from './employee/update-employee-details/update-employee-details.component';
>>>>>>> fdb0b1ea633b626cf091002820f20c664f36454f


const routes: Routes = [
  {path: 'assessmentList', component:AssessmentsComponent},
  {path: 'updateEmployee/:id', component:UpdateEmployeeDetailsComponent},
  {path: 'addAssessment', component:AddAssessmentsComponent},
  {path: 'employeelist', component: EmployeeComponent, resolve: {employees:EmployeesResolverService}},
  {path: 'addemployeedetails', component: AddEmployeeDetailsComponent},
  {path: 'employeeType', component: EmployeeTypeComponent},
  {path: 'allergylist', component: AllergyComponent},
  {path: 'addallergydetails', component: AddAllergyComponent},
  {path: '', redirectTo: '/employeelist', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingComponents = [ AddEmployeeDetailsComponent,EmployeeComponent]
