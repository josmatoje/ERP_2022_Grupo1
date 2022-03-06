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

  constructor(@Inject(MAT_DIALOG_DATA) public data: number,private dialogRef: MatDialogRef<OrderListComponent>,public SupplierService: SupplierService, public ProductService: ProductService, private OrderService : OrderService, private OrderLinesService: OrderLinesService,private dialog:MatDialog,private orderLineConNombreService: OrderLineConNombreService) {
    
  }

  ngOnInit(): void {
    this.orderid = this.data;
    this.OrderService.getOrderById(this.orderid).subscribe(data => {
      this.orderAEditar = data;
      this.notes = this.orderAEditar.notes;
      this.limitOrderDate = this.orderAEditar.limitOrderDate;     
    });

    
    this.orderLineConNombreService.getAllOrderLinesFromOrderWithName(this.orderid).subscribe(data => {
      this.arrayOrderLines = data;
      console.log(data)
    });
  }
  
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

  updatelinea(lineaTMP:ClsOrderLineConNombre) {
    let lineaPedido: ClsOrderLine = {
      id: lineaTMP.id,
      quantity: lineaTMP.quantity,
      currentUnitPrice: lineaTMP.currentUnitPrice,
      subtotal:Number(lineaTMP.quantity) * Number(lineaTMP.currentUnitPrice),
      orderId: lineaTMP.orderId,
      productId: lineaTMP.productId
    }
    this.OrderLinesService.updateOrderLine(lineaPedido).subscribe(data => console.log(data));
  }

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
    this.OrderService.updateOrder(pedido).subscribe(data => console.log(data));
  }

  displayedColumns: string[] = ['Nombre', 'Descripcion', 'Categoria', 'Precio', 'Cantidad', 'Anhadir'];

  eliminarProducto(productoSeleccionado: ClsOrderLineConNombre){   
    this.arrayOrderLines = this.arrayOrderLines.filter(item => item !== productoSeleccionado);
  }

  calcularTotal():number{
    let total = 0;
    this.arrayOrderLines.forEach(prod => 
      total = total + Number(prod.quantity) * Number(prod.currentUnitPrice)
    );
    this.orderAEditar.total = total;
    return total;
  }
  
  close(){
    this.dialogRef.close();
  }
}
