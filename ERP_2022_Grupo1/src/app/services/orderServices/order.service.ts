import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ClsOrder } from 'src/app/model/cls-order';

@Injectable({
  providedIn: 'root'
})
export class OrderService {
  //url with the connection to the api
  url = 'https://erp20212022grupo1api.azurewebsites.net/api/Orders'
  httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };

  constructor(private http: HttpClient) {}
   
  /**
   * Prototype: getAllOrders(): Observable<ClsOrder[]> 
   * Description: Calls the api to get a list with all the orders in the database
   * Preconditions: none
   * Postconditions: Full orders' list of the database
   *  
   * @returns Observable<clsOrder[]>
   */
  getAllOrders(): Observable<ClsOrder[]> {
    return this.http.get<ClsOrder[]>(this.url);
  }

  /**
   * Prototype: getOrderById(orderId: number): Observable<ClsOrder>
   * Description: Calls the api to get an order with the given id in the database
   * Preconditions: none
   * Postconditions: Order gotten with the given id
   
   * @param orderId 
   * @returns Observable<ClsOrder>
   */
  getOrderById(orderId: number): Observable<ClsOrder> {
    return this.http.get<ClsOrder>(this.url +'/'+ orderId);
  }

  /**
  * Prototype: getOrderById(orderId: number): Observable<ClsOrder>
  * Description: Calls the api to get the last Id inserted in the DB
  * Preconditions: none
  
  * @returns Observable<number>
  */
   getLastOrderId(): Observable<number> {
    return this.http.get<number>(this.url +'/LastOrderID');
  }

  /**
   * Prototype: insertOrder(order: ClsOrder): Observable<number>
   * Description: Calls the api to insert an order given  in the database
   * Preconditions: none
   * Postconditions: Order inserted in the database
   * 
   * @param order 
   * @returns Observable depending on the result of the call
   */
  insertOrder(order: ClsOrder): Observable<number> {   
    return this.http.post<number>(this.url,
      order, this.httpOptions);
  }

   /**
   * Prototype: updateOrder(order: ClsOrder): Observable<ClsOrder>
   * Description: Calls the api to update an order given  in the database
   * Preconditions: none
   * Postconditions: Order updated in the database
   * 
   * @param order 
   * @returns Observable depending on the result of the call
   */
  updateOrder(order: ClsOrder): Observable<number> {  
    return this.http.put<number>(this.url, order, this.httpOptions);
  }

  /**
   * Prototype: deleteOrderById(orderId: number): Observable<number>
   * Description: Calls the api to delete an order with the given id in the database
   * Preconditions: none
   * Postconditions: Order deleted in the database
   * 
   * @param orderId 
   * @returns Observable depending on the result of the call
   */
  deleteOrderById(orderId: number): Observable<number> {
    return this.http.delete<number>(this.url +'/'+ orderId, this.httpOptions);
  }
}
