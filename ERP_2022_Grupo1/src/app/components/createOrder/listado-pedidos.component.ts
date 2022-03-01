import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import {FormControl, Validators} from '@angular/forms';
import { ClsSupplier } from 'src/app/model/cls-supplier';
import { SupplierService } from "src/app/services/supplierServices/supplier.service";


@Component({
  selector: 'app-listado-pedidos',
  templateUrl: './listado-pedidos.component.html',
  styleUrls: ['./listado-pedidos.component.scss']
})
export class ListadoPedidosComponent implements OnInit {

  arrayDeSuppliers: Array<ClsSupplier> = [];
  supplierSeleccionado = this.arrayDeSuppliers[1];
  @Output() messageEvent = new EventEmitter<number>();

  constructor(public SupplierService: SupplierService) { }

  ngOnInit(): void {
    this.SupplierService.getAllSuppliers().subscribe(data => this.arrayDeSuppliers = data);
  }

  sendMessage() {
    this.messageEvent.emit(this.supplierSeleccionado.idSupplier)
  }

}
