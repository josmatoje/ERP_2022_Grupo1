import { Component, OnInit } from '@angular/core';
import { ClsSupplier } from 'src/app/model/cls-supplier';
import { SupplierService } from "../../services/supplierServices/supplier.service";


@Component({
  selector: 'app-crear-pedido',
  templateUrl: './crear-pedido.component.html',
  styleUrls: ['./crear-pedido.component.css']
})
export class CrearPedidoComponent implements OnInit {
  
  arrayDeSuppliers: Array<ClsSupplier> = [];
  supplierSeleccionado = this.arrayDeSuppliers[1];
  
  constructor(public SupplierService: SupplierService) { }
  
  
  ngOnInit(): void {
    this.SupplierService.getAllSuppliers().subscribe(data => {
      this.arrayDeSuppliers = data;
      console.log(data);
   });
  }
  
  onChangeObj(newObj:ClsSupplier) {
    console.log(newObj);
    this.supplierSeleccionado = newObj;
  }


}
