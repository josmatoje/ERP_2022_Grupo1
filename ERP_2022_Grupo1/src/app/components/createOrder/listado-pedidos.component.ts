import { Component, EventEmitter, OnInit, Output} from '@angular/core';
import {FormBuilder, FormControl, FormGroup, Validators} from '@angular/forms';
import { ClsSupplier } from 'src/app/model/cls-supplier';
import { SupplierService } from "src/app/services/supplierServices/supplier.service";
import { ProductService } from "src/app/services/productServices/product.service";
import { ClsProduct } from 'src/app/model/cls-product';
import { ClsProductLine } from 'src/app/model/cls-product-line';
import { ClsOrder } from 'src/app/model/cls-order';
import { MatDatepicker } from '@angular/material/datepicker';
import { OrderService } from 'src/app/services/orderServices/order.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-listado-pedidos',
  templateUrl: './listado-pedidos.component.html',
  styleUrls: ['./listado-pedidos.component.scss'],
})
export class ListadoPedidosComponent implements OnInit {

  arrayDeSuppliers: Array<ClsSupplier> = [];
  supplierSeleccionado = this.arrayDeSuppliers[1];
  productList:Array<ClsProductLine>=[];
  auxList:Array<ClsProductLine>=[];
  arrayCart : Array<ClsProductLine>=[];
  orderId:number;
  order:ClsOrder = {
    orderId: 0,
    total: 0,
    orderDate: new Date(2,2,2002),
    limitOrderDate: new Date(2,2,2002),
    notes: " ",
    supplierId: 0
  };
  @Output() SendMeOrder = new EventEmitter();
  
  constructor(private router:Router,public SupplierService: SupplierService, public ProductService: ProductService, private OrderService : OrderService ) {
   }


  ngOnInit(): void {
    try{
      this.SupplierService.getAllSuppliers().subscribe(data => this.arrayDeSuppliers = data);
      this.OrderService.getLastOrderId().subscribe(data => this.orderId = data+1);
    }catch(Exception){
      this.router.navigateByUrl('error')
    }
  }

  displayedColumns: string[] = ['Nombre', 'Descripcion', 'Categoria', 'Precio', 'Cantidad', 'Anhadir'];

  /**
   * Header: onChangeObj(selectedid:number)
   * 
   * Description: Este metodo se encarga de actualizar la tabla de productos
   * en base al id del proveedor.
   * 
   * Precondition: Ninguna
   * Postcondition: Actualiza la tabla
   * @param selectedid number
   */
  onChangeObj(selected:ClsSupplier) {    
    this.productList =[]
    this.auxList = []
    this.arrayCart = []

    try{
      this.ProductService.getProductBySupplierId(selected.idSupplier).subscribe(data =>  {
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
              this.auxList.push(prodTmp)
          });   
          this.productList = this.auxList; 
        }); 
    }catch(Exception){
      this.router.navigateByUrl('error')
    } 
  }
/**
   * Header: aniadirProducto(productoSeleccionado: ClsProductLine)
   * 
   * Description: Este metodo se encarga de añadir un producto al pedido
   * 
   * Precondition: Ninguna
   * Postcondition: Añade la linea de pedido
   * @param productoSeleccionado ClsProductLine
   */
  aniadirProducto(productoSeleccionado: ClsProductLine){
    let unico=true;
    let salir = false;
    let i

      for ( i = 0, i < this.arrayCart.length && !salir; i++;) {     
        let producto =this.arrayCart[i];
        if (producto.orderId==productoSeleccionado.orderId){
          let cantidadFinal=Number (producto.amount)+Number(productoSeleccionado.amount);
          producto.amount=cantidadFinal;
          unico=false; 
          salir = true;        
        }
      }      
      if(unico)
      this.arrayCart.push(JSON.parse(JSON.stringify(productoSeleccionado)));
      productoSeleccionado.amount=0;
      this.SendMeOrder.emit({order:this.order});
  }
}
