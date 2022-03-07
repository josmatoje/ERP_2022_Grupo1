import { initializeApp } from '@firebase/app';
import { getAuth } from '@firebase/auth'
//Firebase configuration string
const firebaseConfig = {
  apiKey: "AIzaSyCgwt2VRlrDGKe4iy9awUCtEXD47df43iI",
  authDomain: "login-erp-a95b6.firebaseapp.com",
  projectId: "login-erp-a95b6",
  storageBucket: "login-erp-a95b6.appspot.com",
  messagingSenderId: "597059530321",
  appId: "1:597059530321:web:9e2264aaec19a94a48d270",
  measurementId: "G-D95TDL5CNC"
};

// Initialize Firebase
const app = initializeApp(firebaseConfig);
const auth = getAuth(app);

export default auth;
