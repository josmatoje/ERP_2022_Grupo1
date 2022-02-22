import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { initializeApp } from 'firebase/app';
import {  } from 'firebase/auth';
import { AuthSigninComponent } from './components/auth-signin/auth-signin.component';
import { ListadoPedidosComponent } from './components/listado_pedidos_component/listado-pedidos.component';
import { ListadoProductosPorSupplierComponent } from './components/listado-productos-por-supplier/listado-productos-por-supplier.component';
import { ListadoProductosAnhadidosComponent } from './components/listado-productos-anhadidos/listado-productos-anhadidos.component';
import {MatTableModule} from '@angular/material/table';
import {MatIconModule} from '@angular/material/icon';
import {MatListModule} from '@angular/material/list';
import {MatCardModule} from '@angular/material/card';
import {MatSelectModule} from '@angular/material/select';
import {MatStepperModule} from '@angular/material/stepper';

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

const app = initializeApp(firebaseConfig);

@NgModule({
  declarations: [
    AppComponent,
    AuthSigninComponent,
    ListadoPedidosComponent,
    ListadoProductosPorSupplierComponent,
    ListadoProductosAnhadidosComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MatTableModule,
    MatIconModule,
    MatListModule,
    MatCardModule,
    MatSelectModule,
    MatStepperModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
