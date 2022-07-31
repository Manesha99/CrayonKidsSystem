import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { EmergencyService } from 'src/app/services/emergency.service';

@Component({
  selector: 'app-add-emergency',
  templateUrl: './add-emergency.component.html',
  styleUrls: ['./add-emergency.component.css']
})
export class AddEmergencyComponent implements OnInit {


  emergencyForm = new FormGroup({
    details:new FormControl(''),
    date:new FormControl(''),
  })
  constructor(private emergencyService: EmergencyService, private router: Router) { }

  ngOnInit(): void {
  }


  onSubmit(){
    this.emergencyService.addEmergency(this.emergencyForm.value) 
    this.router.navigate(['/emergencylist'])
    }

}
