import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { ClsOrder } from 'src/app/model/cls-order';
import { OrderService } from 'src/app/services/orderServices/order.service';
import { Routes, RouterModule, Router } from '@angular/router';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { StepperCreateOrderCompleteComponent } from '../stepper-create-order-complete/stepper-create-order-complete.component';
import { ConfirmingDialogComponent } from '../confirming-dialog/confirming-dialog.component';


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
          this.accionConfirmarBorrado(orderid)          
        } catch (error) {
          console.log(error);
        }
      }      
    } 
    ); 
  }

  accionConfirmarBorrado(orderid:number){
    this.OrderService.deleteOrderById(orderid).subscribe(lines => console.log(lines));
    this.actualizaLista();
  }
}
