import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { ClsOrder } from 'src/app/model/cls-order';
import { OrderService } from 'src/app/services/orderServices/order.service';
import { Routes, RouterModule, Router } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { StepperCreateOrderCompleteComponent } from '../stepper-create-order-complete/stepper-create-order-complete.component';
import { ConfirmingDialogComponent } from '../confirming-dialog/confirming-dialog.component';
import { ClsOrderLine } from 'src/app/model/cls-order-line';
import { StepperEditOrderComponent } from '../stepper-edit-order/stepper-edit-order.component';


@Component({
  selector: 'app-order-list',
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.scss']
})
export class OrderListComponent implements AfterViewInit {

  cargando:boolean = true;
  displayedColumns: string[] = ['id', 'total', 'date', 'limit', 'edit', 'symbol'];
  ordersList = new Array<ClsOrder>()
  dataSource = new MatTableDataSource<ClsOrder>();
  @ViewChild(MatPaginator) paginator: MatPaginator;

  constructor(public OrderService: OrderService, private router: Router, private dialog: MatDialog) {

  }

  ngOnInit(): void {
    try{
      this.OrderService.getAllOrders().subscribe(data => {
        this.ordersList = data
        this.dataSource.data = this.ordersList;
        this.dataSource.paginator = this.paginator;
        this.cargando=false;      
      })
    }catch(Exception){
        this.router.navigateByUrl('error')
    }
  }

  ngAfterViewInit(): void {

  }

  goCreateOrder() {
    const dialogConfig = new MatDialogConfig();

    dialogConfig.disableClose = false;
    dialogConfig.autoFocus = true;
    dialogConfig.backdropClass = 'bdrop';

    const dialogRef = this.dialog.open(StepperCreateOrderCompleteComponent, dialogConfig);
    dialogRef.afterClosed().subscribe(result => this.actualizaLista())
  }

  /**
   * Header: actualizaLista() 
   * 
   * Description: Este metodo se encarga de actualizar la lista de pedidos.
   * 
   * Precondition: Ninguna
   * Postcondition: Actualizar la lista de pedidos
   */
  actualizaLista() {
    try{
      this.OrderService.getAllOrders().subscribe(data => {
        this.ordersList = data
        this.dataSource.data = this.ordersList;
        this.dataSource.paginator = this.paginator;
      })
    }catch(Exception){
      this.router.navigateByUrl('error')
    }
  }

  /**
   * Header: borrarPedido(orderid: number)
   * 
   * Description: Este metodo se encarga de borrar un pedido.
   * 
   * Precondition: Ninguna
   * Postcondition: Borra un pedido en base a su id.
   * @param orderid number
   */
  borrarPedido(orderid: number) {

    const dialogRef = this.dialog.open(ConfirmingDialogComponent);

    dialogRef.afterClosed().subscribe(data => {
      if (data) {
        try {
          this.OrderService.deleteOrderById(orderid).subscribe(lines => {
            console.log(lines)
            this.actualizaLista()
            }
          );         
        } catch (error) {
          this.router.navigateByUrl('error');
        }
      }      
    } 
    ); 
  }
  /**
   * Header: updatePedido(orderId:number)
   * 
   * Description: Este metodo se encarga actualizar el pedido
   * 
   * Precondition: Ninguna
   * Postcondition: Actualiza el pedido
   * @param orderId number
   */
  updatePedido(orderId:number){

    const dialogRef = this.dialog.open(StepperEditOrderComponent, {
      backdropClass : 'bdrop',
      data:orderId
    });   
    
    dialogRef.afterClosed().subscribe(result => this.actualizaLista())
    
  }
}
