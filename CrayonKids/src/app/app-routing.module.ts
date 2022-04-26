import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
//import { AddEmployeeTypeComponent } from './add-employee-type/add-employee-type.component';
import { AddEmployeeDetailsComponent } from './add-employee-details/add-employee-details.component';
//import { AddEmployeeTypeComponent } from './add-employee-type/add-employee-type.component';

const routes: Routes = [
  //{path: 'addemployeetype', component: },
  {path: 'addemployeedetails', component: AddEmployeeDetailsComponent},
  {path: '', redirectTo: '/addemployeedetails', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingComponents = [ AddEmployeeDetailsComponent]
