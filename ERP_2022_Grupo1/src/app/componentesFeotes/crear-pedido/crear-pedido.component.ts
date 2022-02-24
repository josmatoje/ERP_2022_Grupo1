import { Component, OnInit } from '@angular/core';

import { ClsSupplier } from 'src/app/model/cls-supplier';
import { ClsProductLine } from 'src/app/model/cls-product-line'


import { SupplierService } from "src/app/services/supplierServices/supplier.service";
import { ProductService } from "src/app/services/productServices/product.service";


@Component({
  selector: 'app-crear-pedido',
  templateUrl: './crear-pedido.component.html',
  styleUrls: ['./crear-pedido.component.css']
})
export class CrearPedidoComponent implements OnInit {
  
  arrayDeSuppliers: Array<ClsSupplier> = [];
  
  arrayProduct : Array<ClsProductLine>=[];
  
  arrayCart : Array<ClsProductLine>=[];
  
  supplierSeleccionado = this.arrayDeSuppliers[1];
  
  constructor(public SupplierService: SupplierService, public ProductService: ProductService) { }
  
  
  ngOnInit(): void {    
    this.SupplierService.getAllSuppliers().subscribe(data => this.arrayDeSuppliers = data);    
  }
  
  onChangeObj(selected:ClsSupplier) {
    //console.log(selected);    
    this.arrayCart=[];
    this.arrayProduct=[];
    this.ProductService.getProductBySupplierId(selected.idSupplier).subscribe(data => {
      data.forEach(prod => {
        let  prodTmp : ClsProductLine={
          orderId: prod.orderId,
          name:prod.name,
          description: prod.description,
          unitPrice: prod.unitPrice,
          category:prod.category,
          amount:0,
          status:false
        };
        this.arrayProduct.push(prodTmp)      
      });     
    }); 
  }
  
  aniadirProducto(productoSeleccionado: ClsProductLine){
    let unico=true;
    if (productoSeleccionado.amount!=0){
      for (var i = 0, len = this.arrayCart.length; i < len; i++) {     
        let producto =this.arrayCart[i];
        if (producto.orderId==productoSeleccionado.orderId){
          let cantidadFinal=Number (producto.amount)+Number(productoSeleccionado.amount);
          producto.amount=cantidadFinal;
          unico=false     
          break;     
        }
      }       
      if(unico)
      this.arrayCart.push(JSON.parse(JSON.stringify(productoSeleccionado)));
      productoSeleccionado.amount=0;
    }
    else
    alert("Introduzca una cantidad a solicitar primero")
  }
  
  eliminarProducto(productoSeleccionado: ClsProductLine){   
    this.arrayCart = this.arrayCart.filter(item => item !== productoSeleccionado);
  }     
  
}

