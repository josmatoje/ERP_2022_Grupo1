import { Component, EventEmitter, Inject, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ClsOrder } from 'src/app/model/cls-order';
import { ClsProductLine } from 'src/app/model/cls-product-line';
import { ClsSupplier } from 'src/app/model/cls-supplier';
import { SupplierService } from "src/app/services/supplierServices/supplier.service";
import { ProductService } from "src/app/services/productServices/product.service";
import { OrderService } from 'src/app/services/orderServices/order.service';
import { ClsOrderLine } from 'src/app/model/cls-order-line';
import { OrderLinesService } from 'src/app/services/orderLinesservices/order-lines.service';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ConfirmingDialogComponent } from '../confirming-dialog/confirming-dialog.component';
import { OrderListComponent } from '../order-list/order-list.component';
import { ClsOrderLineConNombre } from 'src/app/model/cls-order-line-con-nombre';
import { OrderLineConNombreService } from 'src/app/services/orderLineConNombre/order-line-con-nombre.service';
import { not } from '@angular/compiler/src/output/output_ast';
import { Router } from '@angular/router';

@Component({
  selector: 'app-stepper-edit-order',
  templateUrl: './stepper-edit-order.component.html',
  styleUrls: ['./stepper-edit-order.component.scss']
})
export class StepperEditOrderComponent implements OnInit {

  orderAEditar: ClsOrder = {
    orderId: 0,
    supplierId: 0,
    total: 0,
    orderDate: new Date(),
    limitOrderDate: new Date(),
    notes:""
  };
  arrayOrderLines : Array<ClsOrderLineConNombre>=[];
  notes:String;
  limitOrderDate:Date;
  orderid:number;

  constructor(@Inject(MAT_DIALOG_DATA) public data: number,private router:Router,private dialogRef: MatDialogRef<OrderListComponent>,public SupplierService: SupplierService, public ProductService: ProductService, private OrderService : OrderService, private OrderLinesService: OrderLinesService,private dialog:MatDialog,private orderLineConNombreService: OrderLineConNombreService) {
    
  }

  ngOnInit(): void {
    this.orderid = this.data;
    try{
      this.OrderService.getOrderById(this.orderid).subscribe(data => {
        this.orderAEditar = data;
        this.notes = this.orderAEditar.notes;
        this.limitOrderDate = this.orderAEditar.limitOrderDate;     
      });
      this.orderLineConNombreService.getAllOrderLinesFromOrderWithName(this.orderid).subscribe(data => {
        this.arrayOrderLines = data;
        console.log(data)
      });
    }catch(Exception){
      this.router.navigateByUrl('error');
    }
  }
  /**
   * header: updateOrder() 
   * 
   * Description: Este metodo se encarga de gestionar cuando se actualiza y cuando un pedido
   * 
   * Precondition: Ninguna
   * Poscondition: Actualiza el pedido
   */
  updateOrder() {
    let todoOk = true;
    this.arrayOrderLines.forEach(lineaTMP => {
      if (isNaN(lineaTMP.quantity) || Number(lineaTMP.quantity) < 0) {
        alert("Numero no válido")
        todoOk = false;
      }
      else {
        this.updatelinea(lineaTMP);
      }
    });
    if (todoOk)
      this.updatePedido();
  }

  /**
   * Header: updatelinea(lineaTMP:ClsOrderLineConNombre)
   * 
   * Description: Este metodo se encarga de actualizar una linea de un pedido.
   * 
   * Precondition: Ninguna
   * Postcondition: Actualiza la linea de pedido
   * @param lineaTMP ClsOrderLineConNombre
   */
  updatelinea(lineaTMP:ClsOrderLineConNombre) {
    let lineaPedido: ClsOrderLine = {
      id: lineaTMP.id,
      quantity: lineaTMP.quantity,
      currentUnitPrice: lineaTMP.currentUnitPrice,
      subtotal:Number(lineaTMP.quantity) * Number(lineaTMP.currentUnitPrice),
      orderId: lineaTMP.orderId,
      productId: lineaTMP.productId
    }
    try{
      this.OrderLinesService.updateOrderLine(lineaPedido).subscribe(data => console.log(data));
    }catch(Exception){
      this.router.navigateByUrl('error');
    }
  }

  /**
   * Header: updatePedido()
   * 
   * Description: Este metodo se encarga de actualizar un pedido.
   * 
   * Precondition: Ninguna
   * Postcondition: Actualiza el pedido
   */
  updatePedido() {
    const pedido: ClsOrder = {
      orderId: this.orderAEditar.orderId,
      total:this.calcularTotal(),
      orderDate: new Date(),
      limitOrderDate: this.orderAEditar.limitOrderDate,
      notes: this.orderAEditar.notes,
      supplierId: this.orderAEditar.supplierId
    }
    this.orderAEditar = pedido;
    try{
      this.OrderService.updateOrder(pedido).subscribe(data => console.log(data));
    }catch(Exception){
      this.router.navigateByUrl('error');
    }
  }

  displayedColumns: string[] = ['Nombre', 'Descripcion', 'Categoria', 'Precio', 'Cantidad', 'Anhadir'];

  /**
   * Header: eliminarProducto(productoSeleccionado: ClsOrderLineConNombre)
   * 
   * Description: Este metodo se encarga de eliminar un producto de un pedido.
   * 
   * Precondition: Ninguna
   * Postcondition: Elimina el producto del pedido
   * @param productoSeleccionado
   */
  eliminarProducto(productoSeleccionado: ClsOrderLineConNombre){   
    this.arrayOrderLines = this.arrayOrderLines.filter(item => item !== productoSeleccionado);
  }

  /**
   * Header: calcularTotal():number
   * 
   * Description: Este metodo se encarga de calcular el total del pedido.
   * 
   * Precondition: Ninguna
   * Postcondition: Calcula el total del pedido
   * @returns total: number
   */
  calcularTotal():number{
    let total = 0;
    this.arrayOrderLines.forEach(prod => 
      total = total + Number(prod.quantity) * Number(prod.currentUnitPrice)
    );
    this.orderAEditar.total = total;
    return total;
  }
  
  /**
   * Header:close()
   * 
   * Description: Este metodo se encargaa de cerra un dialog
   * 
   * Preconditions: Ninguna
   * Postconditions: Cierra el dialog
   */
  close(){
    this.dialogRef.close();
  }
}
