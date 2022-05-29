import { Component, OnInit, Input } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeService } from 'src/app/services/employee.service';

@Component({
  selector: 'app-update-employee-details',
  templateUrl: './update-employee-details.component.html',
  styleUrls: ['./update-employee-details.component.css']
})
export class UpdateEmployeeDetailsComponent implements OnInit {  
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
    postalCode:new FormControl('')

  }
  )


  employee: any
  constructor(private employeeService: EmployeeService, private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.employee = this.employeeService.getEmployee(+this.route.snapshot.params['id'])
    console.log(this.employee)
  }
  onSubmit(){
    this.employeeService.update(this.employeeForm.value) 
    this.router.navigate(['/employeelist'])
    }
    cancel(){
      this.router.navigate(['/employeelist'])
  }
}