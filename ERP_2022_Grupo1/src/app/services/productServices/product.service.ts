import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ClsProduct } from 'src/app/model/cls-product'; 

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  //url with the connection to the api
  url = 'https://erp20212022grupo1api.azurewebsites.net/api/Products'
  httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };

  constructor(private http: HttpClient) {}
  
  /**
   * Prototype: getAllProducts(): Observable<ClsProduct[]>
   * Description: Calls the api to get a list with all the prodcts in the database
   * Preconditions: none
   * Postconditions: Full products' list of the database
   *  
   * @returns Observable<ClsProduct[]>
   */
  getAllProducts(): Observable<ClsProduct[]> {
    return this.http.get<ClsProduct[]>(this.url);
  }

  /**
   * Prototype: getProductById(productId: number): Observable<ClsProduct>
   * Description: Calls the api to get a product with the given id in the database
   * Preconditions: none
   * Postconditions: Product gotten with the given id
   
  * @param productId 
  * @returns Observable<ClsProduct>
  */
  getProductById(productId: number): Observable<ClsProduct> {
    return this.http.get<ClsProduct>(this.url +'/'+ productId);
  }

  /**
   * Prototype: getProductoBySupplierId(supplierId: number): Observable<ClsProduct>
   * Description: Calls the api to get a list of products given the id of a supplier in the database
   * Preconditions: none
   * Postconditions: List of products gotten with the given supplier id
   * @param supplierId 
   * @returns Observable<ClsProduct>
   */
   getProductBySupplierId(supplierId: number): Observable<ClsProduct[]> {
    return this.http.get<ClsProduct[]>(this.url + '/Supplier/'+ supplierId);
  }
}
