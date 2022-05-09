import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { EmployeeService } from '../services/employee.service';
import { Employee } from '../shared/employee';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  
  employees: any;
  employee: any;  

	constructor(private employeeService: EmployeeService, private route: ActivatedRoute) {}

	 ngOnInit(): void{ 
    //this.employees = this.employeeService.getEmployees().subscribe(employees => {this.employees = employees})
   this.employees = this.route.snapshot.data['employees']
  

  }
    

    deleteEmployee(id:number){
      this.employeeService.deleteEmployee(id)
      location.reload()
    }
    
    getEmployee(id:number){
      this.employeeService.getEmployee(id)

    }
}
