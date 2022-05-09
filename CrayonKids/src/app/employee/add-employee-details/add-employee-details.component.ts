import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeService } from '../../services/employee.service';

@Component({
  selector: 'app-add-employee-details',
  templateUrl: './add-employee-details.component.html',
  styleUrls: ['./add-employee-details.component.css']
})
export class AddEmployeeDetailsComponent implements OnInit {
  employeeForm = new FormGroup({
    name:new FormControl(''),
    surname:new FormControl(''),
    birthDate:new FormControl(''),
    hireDate:new FormControl(''),
    email:new FormControl(''),
    contactNr:new FormControl(''),
    streetAddress:new FormControl(''),
    address2:new FormControl(''),
    province:new FormControl(''),
    city:new FormControl(''),
    postalCode:new FormControl(''),

  }
  )
  constructor(private employeeService: EmployeeService, private router: Router) { }

  ngOnInit(): void {
    
  }
  cancel(){
    this.router.navigate(['/employeelist'])
}
onSubmit(){
	this.employeeService.addEmployee(this.employeeForm.value) 
	this.router.navigate(['/employeelist'])
	}
}
