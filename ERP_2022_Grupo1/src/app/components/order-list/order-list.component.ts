import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import {MatPaginator} from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';

export class ClsOrder{

}

const ELEMENT_DATA: ClsOrder[] = [
  {orderId: 1, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 1, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 1, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 1, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 1, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 1, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 1, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 1, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 1, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 1, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 1, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 1, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 2, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 2, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 2, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 2, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 2, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 2, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 2, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 2, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 2, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 2, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 2, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 2, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 3, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 3, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 3, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 3, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 3, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 3, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 3, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 3, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 3, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 3, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 3, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1},
  {orderId: 3, total: 100, orderDate: new Date("2019-01-16"), limitOrderDate: new Date("2019-01-16"),notes: " ",supplierId: 1}
];

@Component({
  selector: 'app-order-list',
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.scss']
})
export class OrderListComponent implements AfterViewInit{
  displayedColumns: string[] = ['id', 'total', 'date','limit','edit', 'symbol'];
  dataSource = new MatTableDataSource<ClsOrder>(ELEMENT_DATA);
  @ViewChild(MatPaginator) paginator: MatPaginator;
  constructor() { 

  }
  ngAfterViewInit(): void {
    this.dataSource.paginator = this.paginator;
  }
  
}
