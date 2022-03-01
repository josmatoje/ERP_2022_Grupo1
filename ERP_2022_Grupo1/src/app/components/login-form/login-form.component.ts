import { Component, OnInit } from '@angular/core';
import {FormControl, Validators, FormGroup} from '@angular/forms';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.scss']
})
export class LoginFormComponent implements OnInit {
  form: FormGroup;
  hide = true;

  email: FormControl;
  password: FormControl;
  constructor() { }
  
  getErrorMessage() {
    var text : String;
    if (this.email.hasError('required')) {
      text = 'You must enter a value';
    }

    text = this.email.hasError('email') ? 'Not a valid email' : '';
    return text;
  }

  getErrorMessagePassword() {  
    return this.email.hasError('required') ? 'You must enter a value' : '';    
  }

  ngOnInit(): void {
    this.email = new FormControl('', [Validators.required, Validators.email]);
    this.password = new FormControl('', [Validators.required]);
    this.form=new FormGroup(
      {      
        email : this.email,
        password : this.password
      }      
    );
  }

}
