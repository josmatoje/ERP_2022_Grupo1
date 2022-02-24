import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-stepper-create-order-complete',
  templateUrl: './stepper-create-order-complete.component.html',
  styleUrls: ['./stepper-create-order-complete.component.scss']
})
export class StepperCreateOrderCompleteComponent implements OnInit {

  firstFormGroup: FormGroup;
  secondFormGroup: FormGroup;

  constructor(private _formBuilder: FormBuilder) {}

  ngOnInit() {
    this.firstFormGroup = this._formBuilder.group({
      firstCtrl: '',
    });
    this.secondFormGroup = this._formBuilder.group({
      secondCtrl: '',
    });
  }
}

