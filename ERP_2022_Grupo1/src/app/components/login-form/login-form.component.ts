import { Component, OnInit } from '@angular/core';
import { FormControl, Validators, FormGroup} from '@angular/forms';
import * as firebase from '../../../firebase/firebase';
import { createUserWithEmailAndPassword, signInWithEmailAndPassword, onAuthStateChanged } from '@firebase/auth';
import { Router } from '@angular/router';

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
  
  constructor(private router:Router) { }

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

  getErrorMessageEmail() {
    var text : String;
    if (this.email.hasError('required')) {
      text = 'You must enter a value';
    }else{
      text = this.email.hasError('email') ? 'Not a valid email' : '';
    }

    return text;
  }

  getErrorMessagePassword() {
    return this.password.hasError('required') ? 'You must enter a value' : '';
  }

  public createAccount() {
    const auth = firebase.default;
    var email = this.email.value;
    var password = this.password.value;
    console.log(email+' '+password);
    createUserWithEmailAndPassword(auth, email, password)
      .then((userCredential) => {
        // Signed in
        const user = userCredential.user;
      })
      .catch((error) => {
        const errorCode = error.code;
        const errorMessage = error.message;
        alert(errorMessage);
      });
  }

  public login(){
    const auth = firebase.default;

    onAuthStateChanged(auth, (user) => {
      if (user) {//Si ha iniciado sesion
        //User tiene muchas propiedades disponibles
        const uid = user.uid;
        const email = user.email;
        const photoUrl = user.photoURL;
        this.router.navigateByUrl('modules')
      } 
    });

    signInWithEmailAndPassword(auth, this.email.value, this.password.value).then((userCredential) => {
        const user = userCredential.user;
    })
    .catch((error) => {
      const errorCode = error.code;
      const errorMessage = error.message;
    });
  }

}
