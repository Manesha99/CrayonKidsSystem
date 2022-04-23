import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddEmployeeTypeComponent } from './add-employee-type/add-employee-type.component';

const routes: Routes = [
  {path: 'addemployeetype', component: AddEmployeeTypeComponent},
  {path: '', redirectTo: '/addemployeetype', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
