import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { initializeApp } from 'firebase/app';
import { getAuth, signInWithEmailAndPassword } from 'firebase/auth';
import { AuthSigninComponent } from './components/auth-signin/auth-signin.component';
import { SigninFormComponent } from './components/signin-form/signin-form.component';
import { LoginFormComponent } from './components/login-form/login-form.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { ReactiveFormsModule } from '@angular/forms';
import {MatIconModule} from '@angular/material/icon';


// TODO: Replace the following with your app's Firebase project configuration
const firebaseConfig = {
  apiKey: "AIzaSyCgwt2VRlrDGKe4iy9awUCtEXD47df43iI",
  authDomain: "login-erp-a95b6.firebaseapp.com",
  projectId: "login-erp-a95b6",
  storageBucket: "login-erp-a95b6.appspot.com",
  messagingSenderId: "597059530321",
  appId: "1:597059530321:web:9e2264aaec19a94a48d270",
  measurementId: "G-D95TDL5CNC"
};

const app = initializeApp(firebaseConfig);

@NgModule({
  declarations: [
    AppComponent,
    AuthSigninComponent,
    SigninFormComponent,
    LoginFormComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule, 
    MatFormFieldModule,
    ReactiveFormsModule, 
    MatIconModule,
    MatInputModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
