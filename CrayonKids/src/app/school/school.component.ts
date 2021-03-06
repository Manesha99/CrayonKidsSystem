import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { SchoolService } from '../services/school.service';
import { School } from '../shared/school';

@Component({
  selector: 'app-school',
  templateUrl: './school.component.html',
  styleUrls: ['./school.component.css']
})
export class SchoolComponent implements OnInit {

  schools: any

  constructor(private schoolService: SchoolService, private route: Router, private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void { 

    this.schools = this.schoolService.getSchools().subscribe(schools => {this.schools = schools})
  
    this.schools = this.activatedRoute.snapshot.data['schools']
  }

  deleteSchool(id: number){
    this.schoolService.deleteSchool(id)
    location.reload()
  }
  getSchool(id:number){
    this.schoolService.getSchool(id)

  }
}
