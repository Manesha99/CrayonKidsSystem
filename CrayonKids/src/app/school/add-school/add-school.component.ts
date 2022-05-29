import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { SchoolService } from 'src/app/services/school.service';


@Component({
  selector: 'app-add-school',
  templateUrl: './add-school.component.html',
  styleUrls: ['./add-school.component.css']
})
export class AddSchoolComponent implements OnInit {

  schoolForm = new FormGroup({
    schoolName: new FormControl(''),
    schoolLocation: new FormControl(''),
    schoolInfoDetails: new FormControl(''),
  })


  constructor(private schoolService: SchoolService, private router: Router, private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
  }
  cancel(){
    this.router.navigate(['/schoollist'])
  }

  onSubmit(){
    this.schoolService.addSchool(this.schoolForm.value)
    this.router.navigate(['/schoollist'])
  }
  }

