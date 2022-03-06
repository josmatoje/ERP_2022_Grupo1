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

  displayedColumns: string[] = ['id', 'total', 'date', 'limit', 'edit', 'symbol'];
  ordersList = new Array<ClsOrder>()
  dataSource = new MatTableDataSource<ClsOrder>();
  @ViewChild(MatPaginator) paginator: MatPaginator;

  constructor(public OrderService: OrderService, private router: Router, private dialog: MatDialog) {

  }

  ngOnInit(): void {
    this.OrderService.getAllOrders().subscribe(data => {
      this.ordersList = data
      this.dataSource.data = this.ordersList;
      this.dataSource.paginator = this.paginator;
      console.log(data)
    })

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

  actualizaLista() {
    this.OrderService.getAllOrders().subscribe(data => {
      this.ordersList = data
      this.dataSource.data = this.ordersList;
      this.dataSource.paginator = this.paginator;
    })
  }

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
          console.log(error);
        }
      }      
    } 
    ); 
  }
   
  updatePedido(orderId:number){

    const dialogRef = this.dialog.open(StepperEditOrderComponent, {
      backdropClass : 'bdrop',
      data:orderId
    });   
    
    dialogRef.afterClosed().subscribe(result => this.actualizaLista())
    
  }
}
