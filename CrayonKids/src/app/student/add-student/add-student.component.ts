import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { StudentService } from 'src/app/services/student.service';
import { Student } from 'src/app/shared/student';


@Component({
  selector: 'app-add-student',
  templateUrl: './add-student.component.html',
  styleUrls: ['./add-student.component.css']
})
export class AddStudentComponent implements OnInit {
  studentForm = new FormGroup({
    stduentName: new FormControl(''),
    studentSurname: new FormControl(''),
    studentGrade: new FormControl(''),
    Parent_GuardianID: new FormControl(''),
  })
  students: any

  constructor(private studentService: StudentService, private router: Router, private activatedRoute: ActivatedRoute) { }

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

  cancel(){
    this.router.navigate(['/studentlist'])
  }

  onSubmit(){
    this.studentService.addStudent(this.studentForm.value)
    this.router.navigate(['/schoollist'])
  }


}
