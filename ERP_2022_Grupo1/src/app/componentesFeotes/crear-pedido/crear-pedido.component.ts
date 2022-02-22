import { Component, OnInit } from '@angular/core';

import { ClsSupplier } from 'src/app/model/cls-supplier';
import { ClsProduct } from 'src/app/model/cls-product';
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
    this.SupplierService.getAllSuppliers().subscribe(data => {
      this.arrayDeSuppliers = data;
      console.log(data);
    });    
    
    this.ProductService.getAllProducts().subscribe(data => {
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
      console.log(data);
    });
  }
  
  onChangeObj(selected:ClsSupplier) {
    console.log(selected);
    //this.supplierSeleccionado = selected;    
  }
  
  aniadirProducto(productoSeleccionado: ClsProductLine){
    
    /*
    showUpdatedItem(newItem){
      let updateItem = this.itemArray.items.find(this.findIndexToUpdate, newItem.id);
      
      let index = this.itemArray.items.indexOf(updateItem);
      
      
      this.itemArray.items[index] = newItem;
      
    }
    
    findIndexToUpdate(newItem) { 
      return newItem.id === this;
    }
    */
    
    this.arrayCart.push(productoSeleccionado);
    console.log(productoSeleccionado);
  }
  
  eliminarProducto(productoSeleccionado: ClsProductLine){
    /*
    const index: number = this.arrayCart.indexOf());
    this.arrayCart.splice(index, 1);
    */
    
    this.arrayCart = this.arrayCart.filter(item => item !== productoSeleccionado);
  }     
  
}

