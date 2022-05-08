import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, Resolve, RouterStateSnapshot } from '@angular/router';
import { EmployeeService } from './employee.service';
import {map} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EmployeesResolverService implements Resolve<any>{

  constructor(private employeeService: EmployeeService) { }

  resolve() {
    return this.employeeService.getEmployees().pipe(map((employees) => employees))
  }
}
