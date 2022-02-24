import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListadoPedidosComponent } from './components/createOrder/listado-pedidos.component';

const routes: Routes = [
  {path:'listado', component:ListadoPedidosComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
