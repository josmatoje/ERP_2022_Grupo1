import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListadoPedidosComponent } from './components/createOrder/listado-pedidos.component';
import { ModulesComponent } from './components/modules/modules.component';
import { OrderListComponent } from './components/order-list/order-list.component';
import { StepperCreateOrderCompleteComponent } from './components/stepper-create-order-complete/stepper-create-order-complete.component';

const routes: Routes = [
  {path:'createorder', component:StepperCreateOrderCompleteComponent},
  {path:'orderlist', component:OrderListComponent},
  {path:'', component:ModulesComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
