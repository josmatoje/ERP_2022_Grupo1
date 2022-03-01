import { Component, OnInit, ChangeDetectionStrategy, ChangeDetectorRef } from '@angular/core';
import {FormControl, Validators} from '@angular/forms';
import { ClsSupplier } from 'src/app/model/cls-supplier';
import { SupplierService } from "src/app/services/supplierServices/supplier.service";
import { ProductService } from "src/app/services/productServices/product.service";
import { ClsProduct } from 'src/app/model/cls-product';
import { ClsProductLine } from 'src/app/model/cls-product-line';

@Component({
  selector: 'app-listado-pedidos',
  templateUrl: './listado-pedidos.component.html',
  styleUrls: ['./listado-pedidos.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class ListadoPedidosComponent implements OnInit {

  arrayDeSuppliers: Array<ClsSupplier> = [];
  supplierSeleccionado = this.arrayDeSuppliers[1];
  productList:Array<ClsProductLine>=[];

  constructor(public SupplierService: SupplierService, public ProductService: ProductService,private cd: ChangeDetectorRef) { }

  ngOnInit(): void {
    this.SupplierService.getAllSuppliers().subscribe(data => this.arrayDeSuppliers = data);
  }

  displayedColumns: string[] = ['Nombre', 'Descripcion', 'Categoria', 'Precio', 'Cantidad', 'Anhadir'];

  onChangeObj(selected:ClsSupplier) {    
    this.productList =[]
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
          this.productList.push(prodTmp)
          this.cd.detectChanges();
      });     
    }); 
  }
  
  
}
