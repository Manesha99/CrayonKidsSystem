import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { School } from '../shared/school';

@Injectable({
  providedIn: 'root'
})
export class SchoolService {

  constructor() {
    if(!localStorage.getItem('schools')){
      let schools = [{
        "id": 1,
        "schoolName": "CrayonKids1",
        "schoolLocation": "street ",
        "schoolInfoDetails" : "This is our first and main school"
      }]
      localStorage.setItem('schools', JSON.stringify(schools))
    }
  }
    getSchools(){
      let schools: [];
      if(localStorage.getItem('schools')){
        schools = JSON.parse(localStorage.getItem('schools')!);
      }
      let subject = new Subject();
    setTimeout(() => {subject.next(schools);
    subject.complete();}, 1000)
    return subject;
  }


  getSchool(id: Number){
    let schools: School[] = [];

    if(localStorage.getItem('schools')){
      schools = JSON.parse(localStorage.getItem('schools')!)
    }

    return schools.find(school => school.id === id)
  }


  addSchool(school: School){
    
    let schools: School[] = []

    if(localStorage.getItem('schools')){
      schools = JSON.parse(localStorage.getItem('schools')!)
    }

    let id = schools.length + 1
    school.id = id
    schools.push(school)
    localStorage.setItem('schools', JSON.stringify(schools))
  }

  deleteSchool(id: number){
    let schools: School[] = []

    if(localStorage.getItem('schools')){
      schools = JSON.parse(localStorage.getItem('schools')!)
    }
    let school = schools.find(school => school.id === id)

    if(school){
      schools.splice(id - 1, 1)
      localStorage.setItem('schools', JSON.stringify(schools))
    }
  }
}
 