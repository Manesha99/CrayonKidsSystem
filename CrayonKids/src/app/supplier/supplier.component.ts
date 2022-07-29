import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { SupplierService } from '../services/supplier.service';
import { Supplier } from '../shared/supplier';

@Component({
  selector: 'app-supplier',
  templateUrl: './supplier.component.html',
  styleUrls: ['./supplier.component.css']
})
export class SupplierComponent implements OnInit {


  suppliers: any;
  supplier: any; 

  constructor(private supplierService: SupplierService, private route: ActivatedRoute) { }

  ngOnInit(): void {

   this.suppliers = this.route.snapshot.data['suppliers']
   console.log(this.suppliers)
   }

   deleteSupplier(id:number){
    this.supplierService.deleteSupplier(id)
    location.reload()
  }
  
  getSupplier(id:number){
    this.supplierService.getSupplier(id)

  }

}
