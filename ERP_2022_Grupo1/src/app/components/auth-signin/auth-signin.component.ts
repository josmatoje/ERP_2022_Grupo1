import { Component, OnInit } from '@angular/core';
import * as firebase from '../../../firebase/firebase';
import { createUserWithEmailAndPassword } from '@firebase/auth';

@Component({
  selector: 'app-auth-signin',
  templateUrl: './auth-signin.component.html',
  styleUrls: ['./auth-signin.component.scss']
})

export class AuthSigninComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  public addTestUser () {
    const auth = firebase.default;
    var email = document.getElementById('email').innerText.trim();
    var password = document.getElementById('password').innerText.trim();
    console.log(email+' '+password);
    createUserWithEmailAndPassword(auth, email, password)
      .then((userCredential) => {
        // Signed in
        const user = userCredential.user;
        alert(user.email);
      })
      .catch((error) => {
        const errorCode = error.code;
        const errorMessage = error.message;
        alert(errorMessage);
      });
  }
}


