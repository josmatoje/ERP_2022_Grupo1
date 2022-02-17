import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SupplierService {

  //url with the connection to the api
  url = 'https://erp20212022grupo1api.azurewebsites.net/api/Suppliers'
  httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };

  constructor(private http: HttpClient) {}
  
  /**
   * Prototype: getAllSuppliers(): Observable<ClsSupplier[]> 
   * Description: Calls the api to get a list with all the suppliers in the database
   * Preconditions: none
   * Postconditions: Full suppliers' list of the database
   *  
   * @returns Observable<ClsSupplier[]>
   */
  getAllSuppliers(): Observable<ClsSupplier[]> {
    return this.http.get<ClsSupplier[]>(this.url);
  }

  /**
   * Prototype: getSupplierById(supplierId: number): Observable<ClsSupplier>
   * Description: Calls the api to get a supplier with the given id in the database
   * Preconditions: none
   * Postconditions: OrderLine gotten with the given id
   
  * @param supplierId 
  * @returns Observable<ClsSupplier>
  */
  getSupplierById(supplierId: number): Observable<ClsSupplier> {
    return this.http.get<ClsSupplier>(this.url +'/'+ supplierId);
  }
}
