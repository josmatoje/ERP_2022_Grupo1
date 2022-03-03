import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { ClsOrder } from 'src/app/model/cls-order';
import { OrderService } from 'src/app/services/orderServices/order.service';

@Component({
  selector: 'app-order-list',
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.scss']
})
export class OrderListComponent implements AfterViewInit{

  displayedColumns: string[] = ['id', 'total', 'date','limit','edit', 'symbol'];
  ordersList = new Array<ClsOrder>()
  dataSource = new MatTableDataSource<ClsOrder>();
  @ViewChild(MatPaginator) paginator: MatPaginator;

  constructor(public OrderService: OrderService) { 
        
  }

  ngOnInit(): void {
    this.OrderService.getAllOrders().subscribe(data => {this.ordersList = data
      this.dataSource.data = this.ordersList;
      this.dataSource.paginator = this.paginator;}) 
      
  }

  ngAfterViewInit(): void {  
    
  }
  
}
