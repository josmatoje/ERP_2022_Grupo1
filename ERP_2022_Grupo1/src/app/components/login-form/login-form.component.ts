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
  //Reference to the form group in the view
  form: FormGroup;
  //Boolean that controls if the password is hidden
  hide = true;


  email: FormControl;
  password: FormControl;

  constructor(private router:Router) { }

  ngOnInit(): void {
    //Build the form access
    this.email = new FormControl('', [Validators.required, Validators.email]);
    this.password = new FormControl('', [Validators.required]);
    this.form=new FormGroup(
      {
        email : this.email,
        password : this.password
      }
    );
  }

  //Gets the error message for the email imput, empty if valid.
  getErrorMessageEmail() {
    var text : String;
    if (this.email.hasError('required')) {
      text = 'You must enter a value';
    }else{
      text = this.email.hasError('email') ? 'Not a valid email' : '';
    }

    return text;
  }

  //Gets the error message for the password imput, empty if valid.
  getErrorMessagePassword() {
    return this.password.hasError('required') ? 'You must enter a value' : '';
  }

  //Instantiates auth connection and checks if the user and password are correct.
  public createAccount() {
    //Auth connection
    const auth = firebase.default;
    //Get values from the form
    var email = this.email.value;
    var password = this.password.value;
    console.log(email+' '+password);
    //Auth method
    createUserWithEmailAndPassword(auth, email, password)
      .then((userCredential) => {
        // Signed in
        const user = userCredential.user;
        alert('Se ha creado el usuario :)')
      })
      .catch((error) => {
        const errorCode = error.code;
        const errorMessage = error.message;
        alert(errorMessage);
      });
  }

  public login(){
    //Auth conenction
    const auth = firebase.default;
    //Observer
    onAuthStateChanged(auth, (user) => {
      if (user) {//Si ha iniciado sesion
        //User tiene muchas propiedades disponibles
        const uid = user.uid;
        const email = user.email;
        const photoUrl = user.photoURL;
        this.router.navigateByUrl('modules')
      }
    });
    //Auth Signin method
    signInWithEmailAndPassword(auth, this.email.value, this.password.value).then((userCredential) => {
        const user = userCredential.user;
    })
    .catch((error) => {
      const errorCode = error.code;
      const errorMessage = error.message;
    });
  }

}
