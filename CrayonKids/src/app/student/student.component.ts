import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { StudentService } from '../services/student.service';
import { Student } from '../shared/student';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  students: any


  constructor(private studentService: StudentService, private route: Router, private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {

    this.students = this.studentService.getStudents().subscribe(students => {this.students = students})
  
    this.students = this.activatedRoute.snapshot.data['students']

  }


  deleteStudent(id: number){
    this.studentService.deleteStudent(id)
    location.reload()
  }

  getStudent(id:number){
    this.studentService.getStudent(id)

  }

}
