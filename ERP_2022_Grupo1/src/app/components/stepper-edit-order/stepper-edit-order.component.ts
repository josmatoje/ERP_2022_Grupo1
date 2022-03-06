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

@Component({
  selector: 'app-stepper-edit-order',
  templateUrl: './stepper-edit-order.component.html',
  styleUrls: ['./stepper-edit-order.component.scss']
})
export class StepperEditOrderComponent implements OnInit {

  arrayDeSuppliers: Array<ClsSupplier> = [];
  idsupplierSeleccionado:number;
  auxList:Array<ClsProductLine>=[];
  arrayCart : Array<ClsProductLine>=[];
  orderAEditar:ClsOrder;
  orderid:number = this.data;
  limitOrderDate:Date;
  notes:string;
  total:number = 0;

  constructor(@Inject(MAT_DIALOG_DATA) public data: number,private dialogRef: MatDialogRef<OrderListComponent>,public SupplierService: SupplierService, public ProductService: ProductService, private OrderService : OrderService, private OrderLinesService: OrderLinesService,private dialog:MatDialog) {}

  ngOnInit(): void {
    console.log(this.orderid);
    this.OrderService.getOrderById(this.orderid).subscribe(result => {
      this.orderAEditar = result;      
    });
  }

  displayedColumns: string[] = ['Nombre', 'Descripcion', 'Categoria', 'Precio', 'Cantidad', 'Anhadir'];

  eliminarProducto(productoSeleccionado: ClsProductLine){   
    this.arrayCart = this.arrayCart.filter(item => item !== productoSeleccionado);
  }

  calcularTotal(){
    this.total = 0;
    this.arrayCart.forEach(prod => 
      this.total = this.total + Number(prod.amount) * Number(prod.unitPrice)
    );
  }
  
  close(){
    this.dialogRef.close();
  }
}
