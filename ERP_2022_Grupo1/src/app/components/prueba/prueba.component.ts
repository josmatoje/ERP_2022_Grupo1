import { Component, OnInit } from '@angular/core';
import { ClsProduct } from 'src/app/model/cls-product';

@Component({
  selector: 'app-prueba',
  templateUrl: './prueba.component.html',
  styleUrls: ['./prueba.component.scss']
})
export class PruebaComponent implements OnInit {

  resultsLength = 0;

  constructor() {}

  ngOnInit(): void {
  }

  listadoProductos: ClsProduct[] = [
    {orderId:1, name:'Patata', description: 'patata', unitPrice:12, category:'patata'},
    {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'},
    {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'},
    {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'},
    {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'},
    {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'},
    {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'},
    {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'},
    {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'},
    {orderId:1, name:'a', description: 'patata', unitPrice:12, category:'patata'}
  ]
  displayedColumns: string[] = ['Nombre', 'Descripcion', 'Categoria', 'Precio',  'Cantidad', 'Anhadir'];
  
}
