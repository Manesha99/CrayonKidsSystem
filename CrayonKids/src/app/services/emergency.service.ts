import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { Emergency } from '../shared/emergency';

@Injectable({
  providedIn: 'root'
})
export class EmergencyService {


  emergencies: any

  constructor() { 
    if(!localStorage.getItem('emergencies')){
      let emergencies = [{
        "id": 1,
        "details": "Abacus Counting" 
        }]
        localStorage.setItem('emergencies', JSON.stringify(emergencies))
     }
  }

  
  getEmergencies(){
    let emergencies:[]
    if (localStorage.getItem('emergencies'))
    {
      emergencies = JSON.parse(localStorage.getItem('emergencies')!)
    }
    let subject = new Subject()
    setTimeout(() => {subject.next(emergencies); subject.complete();},1000)
    return subject
    }



    getEmergency(id: number){
      let emergencies: Emergency[] = []
      
	if(localStorage.getItem('emergencies')){
	  emergencies = JSON.parse(localStorage.getItem('emergencies')!)
	 }
	return emergencies.find(emergency => emergency.id === id)
    }

    addEmergency(emergency:Emergency){
    let emergencies: Emergency[] = []
    if (localStorage.getItem('emergencies'))
    {
      emergencies = JSON.parse(localStorage.getItem('emergencies')!)
    }
    let id = emergencies.length + 1
    emergency.id = id
    emergencies.push(emergency)
    localStorage.setItem('emergencies', JSON.stringify(emergencies))

  }
  deleteEmergency(id: number){
    let emergencies: Emergency[] = []

    if(localStorage.getItem('emergencies')){
      emergencies = JSON.parse(localStorage.getItem('emergencies')!)
    }
    let emergency = emergencies.find(emergency => emergency.id === id)

    if (emergency){
      emergencies.splice(id - 1, 1)
      localStorage.setItem('emergencies', JSON.stringify(emergencies))
    }
  }

}
