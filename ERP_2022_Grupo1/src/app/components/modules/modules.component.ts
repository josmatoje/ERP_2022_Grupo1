import { Component, OnInit } from '@angular/core';
import { Routes, RouterModule, Router } from '@angular/router';

@Component({
  selector: 'app-modules',
  templateUrl: './modules.component.html',
  styleUrls: ['./modules.component.scss']
})
export class ModulesComponent implements OnInit {

  constructor(private router:Router) { }

  ngOnInit(): void {
  }

  /**
   * Header: goOrdersList()
   * 
   * Description: Este metodo se encarga de ir a la pagina de lista de pedidos
   * 
   * Precondition: Ninguna
   * Postcondition: Navega a la lista de pedidos
   */
  goOrdersList(){
    this.router.navigateByUrl('orderlist')
  }
}
