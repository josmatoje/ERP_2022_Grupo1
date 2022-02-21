import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CrearPedidoComponent } from './componentesFeotes/crear-pedido/crear-pedido.component';

import { SupplierService } from "../../src/app/services/supplierServices/supplier.service";

import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    CrearPedidoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [
    SupplierService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
