import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CrearPedidoComponent } from './componentesFeotes/crear-pedido/crear-pedido.component';

import { SupplierService } from "../../src/app/services/supplierServices/supplier.service";

import { HttpClientModule } from '@angular/common/http';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';


// TODO: Replace the following with your app's Firebase project configuration
const firebaseConfig = {
  apiKey: "AIzaSyCgwt2VRlrDGKe4iy9awUCtEXD47df43iI",
  authDomain: "login-erp-a95b6.firebaseapp.com",
  projectId: "login-erp-a95b6",
  storageBucket: "login-erp-a95b6.appspot.com",
  messagingSenderId: "597059530321",
  appId: "1:597059530321:web:9e2264aaec19a94a48d270",
  measurementId: "G-D95TDL5CNC"
};


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
