import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { StudentService } from 'src/app/services/student.service';

@Component({
  selector: 'app-update-student',
  templateUrl: './update-student.component.html',
  styleUrls: ['./update-student.component.css']
})
export class UpdateStudentComponent implements OnInit {

  studentForms = new FormGroup({
    studentname:new FormControl(''),
    studentSurname:new FormControl(''),
    studentGrade:new FormControl(''),
    Parent_GuardianID:new FormControl(''),
  })
  student: any
  constructor(private studentService: StudentService, private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {

    this.student = this.studentService.getStudent(+this.route.snapshot.params['id'])
  }
  onSubmit(){
    this.studentService.addStudent(this.studentForms.value) 
    this.router.navigate(['/studentlist'])
    } }

