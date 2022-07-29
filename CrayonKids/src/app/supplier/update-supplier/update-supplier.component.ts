import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { SupplierService } from 'src/app/services/supplier.service';


@Component({
  selector: 'app-update-supplier',
  templateUrl: './update-supplier.component.html',
  styleUrls: ['./update-supplier.component.css']
})
export class UpdateSupplierComponent implements OnInit {

  supplierForms = new FormGroup({
    name:new FormControl(''),
    email:new FormControl(''),
    contactNr:new FormControl(''),
    Address:new FormControl(''),


  }
  )

  supplier : any

  constructor(private supplierService: SupplierService, private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.supplier = this.supplierService.getSupplier(+this.route.snapshot.params['id'])
    console.log(this.supplier)
  }


  onSubmit(){
    this.supplierService.addSupplier(this.supplierForms.value) 
    this.router.navigate(['/supplierlist'])
    }

}
