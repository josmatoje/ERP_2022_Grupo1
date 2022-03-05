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

  goOrdersList(){
    this.router.navigateByUrl('orderlist')
  }
}
