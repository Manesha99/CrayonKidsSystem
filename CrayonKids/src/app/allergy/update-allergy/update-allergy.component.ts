import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AllergyService } from 'src/app/services/allergy.service';

@Component({
  selector: 'app-update-allergy',
  templateUrl: './update-allergy.component.html',
  styleUrls: ['./update-allergy.component.css']
})
export class UpdateAllergyComponent implements OnInit {

  allergyForm = new FormGroup({
    allergyDetails: new FormControl(''),
    allergyDate: new FormControl(''),
  })

  allergy: any
  constructor(private allergyService: AllergyService, private router: Router, private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.allergy = this.allergyService.getAllergy(+this.activatedRoute.snapshot.params['id'])
    console.log(this.allergy)
  }

  cancel(){
    this.router.navigate(['/allergylist'])
  }

  onSubmit(){
    this.allergyService.addAllergy(this.allergyForm.value)
    this.router.navigate(['/allergylist'])
  }
}
