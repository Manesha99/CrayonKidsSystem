import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router'
import { AddEmployeeDetailsComponent } from './employee/add-employee-details/add-employee-details.component';
import { EmployeeComponent } from './employee/employee.component';
import { EmployeesResolverService } from './services/employees-resolver.service';
import { EmployeeTypeComponent } from './employee/employee-type/employee-type.component';


const routes: Routes = [
  //{path: 'addemployeetype', component: },
  {path: 'employeelist', component: EmployeeComponent, resolve: {employees:EmployeesResolverService}},
  {path: 'addemployeedetails', component: AddEmployeeDetailsComponent},
  {path: 'employeeType', component: EmployeeTypeComponent},
  {path: '', redirectTo: '/employeelist', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingComponents = [ AddEmployeeDetailsComponent,EmployeeComponent]
