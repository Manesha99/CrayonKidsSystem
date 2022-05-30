import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { SchoolService } from 'src/app/services/school.service';

@Component({
  selector: 'app-update-school',
  templateUrl: './update-school.component.html',
  styleUrls: ['./update-school.component.css']
})
export class UpdateSchoolComponent implements OnInit {

  schoolForms = new FormGroup({
    schoolname:new FormControl(''),
    schoolLocation:new FormControl(''),
    schoolInfoDetails:new FormControl(''),
})
    school: any
  constructor(private schoolService: SchoolService, private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {

    this.school = this.schoolService.getSchool(+this.route.snapshot.params['id'])

  }
  onSubmit(){
    this.schoolService.addSchool(this.schoolForms.value) 
    this.router.navigate(['/schoollist'])
    } }

