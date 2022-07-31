import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { EmergencyService } from '../services/emergency.service';
import { Emergency } from '../shared/emergency';

@Component({
  selector: 'app-emergency',
  templateUrl: './emergency.component.html',
  styleUrls: ['./emergency.component.css']
})
export class EmergencyComponent implements OnInit {


  emergencies: any

  constructor(private route2: ActivatedRoute, private emergencyService : EmergencyService) { }


  ngOnInit(): void {
    this.emergencies = this.emergencyService.getEmergencies().subscribe(emergencies => {this.emergencies = emergencies})
  }

  deleteAssessment(id:number){
    this.emergencyService.deleteEmergency(id)
    location.reload()
  }
}
