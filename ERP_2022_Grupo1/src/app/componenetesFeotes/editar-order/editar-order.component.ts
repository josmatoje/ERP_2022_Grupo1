import { Component, OnInit } from '@angular/core';

import { ClsSupplier } from 'src/app/model/cls-supplier';
import { ClsProductLine } from 'src/app/model/cls-product-line'


import { SupplierService } from "src/app/services/supplierServices/supplier.service";
import { ProductService } from "src/app/services/productServices/product.service";
import { OrderService } from 'src/app/services/orderServices/order.service';
import { OrderLinesService } from 'src/app/services/orderLinesservices/order-lines.service';
import { ClsOrder } from 'src/app/model/cls-order';
import { ClsOrderLine } from 'src/app/model/cls-order-line';


@Component({
  selector: 'app-editar-order',
  templateUrl: './editar-order.component.html',
  styleUrls: ['./editar-order.component.css']
})
export class EditarOrderComponent implements OnInit {

  orderAEditar: ClsOrder;
  arrayCart : Array<ClsProductLine>=[];


  constructor(private SupplierService: SupplierService, private ProductService: ProductService, private OrderService : OrderService, private OrderLinesService: OrderLinesService) { }


  numeroFactura: number = 37;
  ngOnInit(): void {
    this.OrderService.getOrderById(this.numeroFactura).subscribe(data => {
      console.log(data);
      this.orderAEditar = data;      
     });
    //this.OrderLinesService.
  }

}
