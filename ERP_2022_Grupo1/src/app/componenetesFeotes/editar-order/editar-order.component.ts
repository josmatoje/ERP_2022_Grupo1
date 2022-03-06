import { Component, OnInit } from '@angular/core';

import { ClsSupplier } from 'src/app/model/cls-supplier';
import { ClsProductLine } from 'src/app/model/cls-product-line'


import { SupplierService } from "src/app/services/supplierServices/supplier.service";
import { ProductService } from "src/app/services/productServices/product.service";
import { OrderService } from 'src/app/services/orderServices/order.service';
import { OrderLinesService } from 'src/app/services/orderLinesservices/order-lines.service';
import { ClsOrder } from 'src/app/model/cls-order';
import { ClsOrderLine } from 'src/app/model/cls-order-line';
import { ClsOrderLineConNombre } from 'src/app/model/cls-order-line-con-nombre';


@Component({
  selector: 'app-editar-order',
  templateUrl: './editar-order.component.html',
  styleUrls: ['./editar-order.component.css']
})
export class EditarOrderComponent implements OnInit {
  
  orderAEditar: ClsOrder;
  arrayOrderLines : Array<ClsOrderLineConNombre>=[];
  
  
  constructor(private ProductService: ProductService, private OrderService : OrderService, private OrderLinesService: OrderLinesService) { }
  
  
  numeroFactura: number = 37;
  ngOnInit(): void {
    this.OrderService.getOrderById(this.numeroFactura).subscribe(data => {
      console.log(data);
      this.orderAEditar = data;      
    });
    this.OrderLinesService.getAllOrderLinesFromOrder(this.numeroFactura).subscribe(data => {
      console.log(data);
      this.arrayOrderLines = data;
    });
  }
  
  alterarFila(orderline:ClsOrderLineConNombre) {
    let  lineaTMP : ClsOrderLine={
      id: orderline.id ,
      quantity: orderline.quantity,
      currentUnitPrice: orderline.currentUnitPrice,
      subtotal:orderline.subtotal,
      orderId: orderline.orderId,
      productId: orderline.orderId          
    };
    this.OrderLinesService.updateOrderLine(lineaTMP).subscribe(data => console.log(data));
    
    const pedido: ClsOrder={
      orderId: this.orderAEditar.orderId,
      total: this.calcularTotal(),
      orderDate: new Date(),
      limitOrderDate: new Date(),
      notes:"cosa",
      supplierId: this.orderAEditar.supplierId
    }
    
  }

  calcularTotal(): number {
    let total = 0;
    this.arrayOrderLines.forEach(prod => 
      total = total + Number(prod.quantity) * Number(prod.currentUnitPrice)
    );
    return total;
  }
  
}
