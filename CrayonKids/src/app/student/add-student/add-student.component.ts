import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { StudentService } from 'src/app/services/student.service';



@Component({
  selector: 'app-add-student',
  templateUrl: './add-student.component.html',
  styleUrls: ['./add-student.component.css']
})
export class AddStudentComponent implements OnInit {
  studentForm = new FormGroup({
    studentName: new FormControl(''),
    studentSurname: new FormControl(''),
    studentGrade: new FormControl(''),
    Parent_GuardianID: new FormControl(''),
  })


  constructor(private studentService: StudentService, private router: Router) { }

  ngOnInit(): void {

  }

  cancel(){
    this.router.navigate(['/studentlist'])
  }

  onSubmit(){
    this.studentService.addStudent(this.studentForm.value)
    this.router.navigate(['/schoollist'])
    alert("Student Successfully Added")
  }
}
