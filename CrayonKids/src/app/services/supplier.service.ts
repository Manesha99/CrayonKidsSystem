import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';
import { Supplier } from '../shared/supplier';

@Injectable({
  providedIn: 'root'
})
export class SupplierService {
 
  constructor() { }


  getSuppliers(){
    let suppliers:[]
    if (localStorage.getItem('suppliers'))
    {
      suppliers = JSON.parse(localStorage.getItem('suppliers')!)
    }
    let subject = new Subject()
    setTimeout(() => {subject.next(suppliers); subject.complete();},1000)
    return subject
    }

    getSupplier(id: number){
      let suppliers: Supplier[] = []
      
	  if(localStorage.getItem('suppliers')){
	     suppliers = JSON.parse(localStorage.getItem('suppliers')!)
	     }
	  return suppliers.find(supplier => supplier.id === id)
    }

    addSupplier(supplier: Supplier){
      let suppliers: Supplier[] = []
      if (localStorage.getItem('suppliers'))
      {
        suppliers = JSON.parse(localStorage.getItem('suppliers')!)
      }
      let id = suppliers.length + 1
      supplier.id = id
      suppliers.push(supplier)
      localStorage.setItem('suppliers', JSON.stringify(suppliers))
  
    }

    deleteSupplier(id: number){
      let suppliers: Supplier[] = []
  
      if(localStorage.getItem('suppliers')){
        suppliers = JSON.parse(localStorage.getItem('suppliers')!)
      }
      let supplier = suppliers.find(supplier => supplier.id === id)
  
      if (supplier){
        suppliers.splice(id - 1, 1)
        localStorage.setItem('suppliers', JSON.stringify(suppliers))
      }
    }






}
