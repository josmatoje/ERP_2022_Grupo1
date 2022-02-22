import { Component, OnInit } from '@angular/core';
import { ClsProduct } from 'src/app/model/cls-product';

@Component({
  selector: 'app-listado-productos-por-supplier',
  templateUrl: './listado-productos-por-supplier.component.html',
  styleUrls: ['./listado-productos-por-supplier.component.scss']
})
export class ListadoProductosPorSupplierComponent implements OnInit {

  listadoProductos: ClsProduct[] = [
    {orderId:1, name:'Patata', description: 'patata', unitPrice:12, category:'patata'},
    {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'},
    {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'},
    {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'},
    {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'},
    {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'},
    {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'}
  ]
  displayedColumns: string[] = ['Nombre', 'Descripcion', 'Categoria', 'Precio', 'Cantidad', 'Anhadir'];
  
  constructor() { }

  ngOnInit(): void {
  }
}


