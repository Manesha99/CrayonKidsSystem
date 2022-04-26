import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../services/employee.service';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  employees: any
	constructor(private employeeService: EmployeeService) {}
	 ngOnInit(): void{ 
    this.employees = this.employeeService.getEmployees().subscribe(employees => {this.employees = employees})
		
    }
}
