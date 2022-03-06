import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ClsOrderLine } from 'src/app/model/cls-order-line';

@Injectable({
  providedIn: 'root'
})
export class OrderLinesService {

  //url with the connection to the api
  url = 'https://erp20212022grupo1api.azurewebsites.net/api/OrderLines'
  httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };

  constructor(private http: HttpClient) {}
  
  /**
   * Prototype: getAllOrderLines(): Observable<clsOrderLines[]> 
   * Description: Calls the api to get a list with all the ordersLines in the database
   * Preconditions: none
   * Postconditions: Full orderLines' list of the database
   *  
   * @returns Observable<clsOrderLine[]>
   */
  getAllOrderLines(): Observable<ClsOrderLine[]> {
    return this.http.get<ClsOrderLine[]>(this.url);
  }

  /**
   * Prototype: getOrderLineById(orderId: number): Observable<ClsOrderLine>
   * Description: Calls the api to get an orderLine with the given id in the database
   * Preconditions: none
   * Postconditions: OrderLine gotten with the given id
   
  * @param orderLineId 
  * @returns Observable<ClsOrderLine>
  */
  getOrderLineById(orderLineId: number): Observable<ClsOrderLine> {
    return this.http.get<ClsOrderLine>(this.url +'/'+ orderLineId);
  }

  /**
   * Prototype: insertOrderLine(order: ClsOrderLine): Observable<ClsOrderLine>
   * Description: Calls the api to insert an orderLine given  in the database
   * Preconditions: none
   * Postconditions: OrderLine inserted in the database
   * 
   * @param orderLine 
   * @returns Observable depending on the result of the call
   */
  insertOrderLine(orderLine: ClsOrderLine): Observable<number> {   
    return this.http.post<number>(this.url,
      orderLine, this.httpOptions);
  }

  /**
   * Prototype: updateOrderLine(orderLine: ClsOrderLine): Observable<ClsOrderLine>
   * Description: Calls the api to update an orderLine given in the database
   * Preconditions: none
   * Postconditions: OrderLine updated in the database
   * 
   * @param orderLine 
   * @returns Observable depending on the result of the call
   */
  updateOrderLine(orderLine: ClsOrderLine): Observable<number> {  
    return this.http.put<number>(this.url+'/'+ orderLine.id, orderLine, this.httpOptions);
  }

  /**
   * Prototype: deleteOrderLineById(orderLineId: number): Observable<number>
   * Description: Calls the api to delete an orderLine with the given id in the database
   * Preconditions: none
   * Postconditions: OrderLine deleted in the database
   * 
   * @param orderLineId 
   * @returns Observable depending on the result of the call
   */
  deleteOrderLineById(orderLineId: number): Observable<number> {
    return this.http.delete<number>(this.url +'/'+ orderLineId, this.httpOptions);
  }
}
