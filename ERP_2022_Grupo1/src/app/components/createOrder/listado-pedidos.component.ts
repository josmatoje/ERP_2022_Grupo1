import { Component, OnInit } from '@angular/core';
import {FormControl, Validators} from '@angular/forms';
import { ClsSupplier } from 'src/app/model/cls-supplier';

@Component({
  selector: 'app-listado-pedidos',
  templateUrl: './listado-pedidos.component.html',
  styleUrls: ['./listado-pedidos.component.scss']
})
export class ListadoPedidosComponent implements OnInit {

  constructor() { }

  //select
  suppliers: ClsSupplier[] = [
    {idSupplier:1,name: 'Pepe'},
    {idSupplier:2,name: 'Ernesto'},
    {idSupplier:3,name: 'Mario'},
    {idSupplier:4,name: 'Maria del Carmen'},
  ];

  ngOnInit(): void {
  }
}
