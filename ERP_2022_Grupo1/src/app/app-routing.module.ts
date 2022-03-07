import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginFormComponent } from './components/login-form/login-form.component';
import { ModulesComponent } from './components/modules/modules.component';
import { OrderListComponent } from './components/order-list/order-list.component';
import { StepperCreateOrderCompleteComponent } from './components/stepper-create-order-complete/stepper-create-order-complete.component';

const routes: Routes = [
  {path:'createorder', component:StepperCreateOrderCompleteComponent},
  {path:'orderlist', component:OrderListComponent},
  {path:'modules', component:ModulesComponent},
  {path:'', component:LoginFormComponent}
  //{path:'', component:OrderListComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
