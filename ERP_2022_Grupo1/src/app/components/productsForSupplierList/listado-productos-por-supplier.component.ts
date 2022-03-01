import { Component, OnInit } from '@angular/core';
import { ClsProduct } from 'src/app/model/cls-product';
import { ClsSupplier } from 'src/app/model/cls-supplier';
import { SupplierService } from "src/app/services/supplierServices/supplier.service";
import { ProductService } from "src/app/services/productServices/product.service";



@Component({
  selector: 'app-listado-productos-por-supplier',
  templateUrl: './listado-productos-por-supplier.component.html',
  styleUrls: ['./listado-productos-por-supplier.component.scss']
})
export class ListadoProductosPorSupplierComponent implements OnInit {

  // listadoProductos: ClsProduct[] = [
  //   {orderId:1, name:'Patata', description: 'patata', unitPrice:12, category:'patata'},
  //   {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'},
  //   {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'},
  //   {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'},
  //   {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'},
  //   {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'},
  //   {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'}
  // ]
  displayedColumns: string[] = ['Nombre', 'Descripcion', 'Categoria', 'Precio', 'Cantidad', 'Anhadir'];
  
  constructor(public SupplierService: SupplierService, public ProductService: ProductService) { }

  idSupplier:number
  supplierSeleccionado:ClsSupplier
  productList:Array<ClsProduct>=[]

  ngOnInit(): void {  }

  receiveMessage($event: number) {
    this.idSupplier = $event
  }

  getProductListBySupplier():void {
    this.ProductService.getProductBySupplierId(this.idSupplier).subscribe(data => this.productList = data);
  }
}


