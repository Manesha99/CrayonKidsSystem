import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { Student } from '../shared/student';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor() {
    if(!localStorage.getItem('students')){
      let students = [{
        "id": 1,
        "studentName": "avenue",
        "studentSurname": "street ",
        "studentGrade" : "98",
        "Parent_GuardianID" : "1"
      }]
      localStorage.setItem('students', JSON.stringify(students))
    }
  }
    getStudents(){
      let students: [];
      if(localStorage.getItem('students')){
        students = JSON.parse(localStorage.getItem('students')!);
      }
      let subject = new Subject();
    setTimeout(() => {subject.next(students);
    subject.complete();}, 1000)
    return subject;
  }

  getStudent(id: Number){
    let students: Student[] = [];

    if(localStorage.getItem('students')){
      students = JSON.parse(localStorage.getItem('students')!)
    }

    return students.find(student => student.id === id)
  }

  addStudent(student: Student){
    
    let students: Student[] = []

    if(localStorage.getItem('students')){
      students = JSON.parse(localStorage.getItem('students')!)
    }

    let id = students.length + 1
    student.id = id
    students.push(student)
    localStorage.setItem('students', JSON.stringify(students))
  }

  deleteStudent(id: number){
    let students: Student[] = []
 
    if(localStorage.getItem('students')){
      students = JSON.parse(localStorage.getItem('students')!)
    }
    let student = students.find(student => student.id === id)

    if(student){
     // student.splice(id - 1, 1)
      localStorage.setItem('students', JSON.stringify(students))
    }
  }

   }

