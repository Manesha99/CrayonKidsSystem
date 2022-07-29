import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { SupplierService } from 'src/app/services/supplier.service';


@Component({
  selector: 'app-add-supplier',
  templateUrl: './add-supplier.component.html',
  styleUrls: ['./add-supplier.component.css']
})
export class AddSupplierComponent implements OnInit {


  supplierForm = new FormGroup({

 
    name:new FormControl(''),
    email:new FormControl(''),
    contactNr:new FormControl(''),
    Address:new FormControl(''),
  }
  )

  constructor(private supplierService: SupplierService, private router: Router) { }

  ngOnInit(): void {
  }


  cancel(){
    this.router.navigate(['/supplierlist'])
}
onSubmit(){
	this.supplierService.addSupplier(this.supplierForm.value) 
	this.router.navigate(['/supplierlist'])
  console.log(['/supplierlist'])
	}


}
