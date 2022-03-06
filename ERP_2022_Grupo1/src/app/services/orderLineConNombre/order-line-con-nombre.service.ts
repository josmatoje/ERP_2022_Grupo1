import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ClsOrderLineConNombre } from 'src/app/model/cls-order-line-con-nombre';

@Injectable({
  providedIn: 'root'
})
export class OrderLineConNombreService {

 //url with the connection to the api
 url = 'https://erp20212022grupo1api.azurewebsites.net/api/OrderLinesWithProductName/'
 httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
 
 constructor(private http: HttpClient) { }
 
 
 /**
 * Prototype: getAllOrderLinesFromOrderWithName(): Observable<clsOrderLines[]> 
 * Description: Calls the api to get a list with all the ordersLines with name in the database
 * Preconditions: none
 * Postconditions: Full orderLines' list of the database
 *  
 * @returns Observable<clsOrderLine[]>
 */
 getAllOrderLinesFromOrderWithName(id:number): Observable<ClsOrderLineConNombre[]> {
   return this.http.get<ClsOrderLineConNombre[]>(this.url+id);
 }
}
