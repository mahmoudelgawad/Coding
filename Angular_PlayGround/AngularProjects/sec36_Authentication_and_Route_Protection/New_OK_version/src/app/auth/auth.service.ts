import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { AuthResponse } from './auth-response.model';
import { BehaviorSubject, catchError, Subject, tap, throwError } from 'rxjs';
import { User } from './user.model';
import { Router } from '@angular/router';

const LOCAL_STORAGE_USER_DATA = "userData";

/*
#DOCUMENTATION#

-Firebase Auth REST API
https://firebase.google.com/docs/reference/rest/auth

- Subject Vs BehaviourSubject
https://rxjs.dev/guide/subject

*/
@Injectable({
  providedIn: 'root',
})
export class AuthService {
  http = inject(HttpClient);
  router = inject(Router);
  firbaseKey = 'AIzaSyCrA14LbLymC_n6WxYvUgIoNUk55mqMbBM';
  tokenIdExpireLogoutTimeout :any;
  // userSubject = new Subject<User>();

  //behavoir subject hold/save one latest value, and will emit that latest saved value
  //once you subscribe immediately
  userBeaviorSubject = new BehaviorSubject<User|null>(null);

  //Sign up with email / password
  signup(username: string, password: string) {
    return this.http
      .post<AuthResponse>(
        `https://identitytoolkit.googleapis.com/v1/accounts:signUp?key=${this.firbaseKey}`,
        {
          email: username,
          password: password,
          returnSecureToken: true,
        }
      )
      .pipe(
        catchError(this.handleErrorResponse),
        tap(resData => this.handleAuthResponse(resData))
      );
  }

  login(email: string, password: string) {
    return this.http.post<AuthResponse>(
      `https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=${this.firbaseKey}`,
      {
        email: email,
        password: password,
        returnSecureToken: true,
      }
    ).pipe(
      catchError(this.handleErrorResponse),
      tap(resData => this.handleAuthResponse(resData))
    );
  }

  logout(){
    this.userBeaviorSubject.next(null);
    // localStorage.clear() // will clear all data 
    localStorage.removeItem(LOCAL_STORAGE_USER_DATA);
    if(this.tokenIdExpireLogoutTimeout){
      clearTimeout(this.tokenIdExpireLogoutTimeout);
      this.tokenIdExpireLogoutTimeout = null;
    }

    this.router.navigate(['auth']);
  }

  autoLogin(){
    const userData:{
      email:string,
      id:string,
      _token:string,
      _tokenExpirationDate:Date
    } = JSON.parse(localStorage.getItem(LOCAL_STORAGE_USER_DATA)!);
    //another way to avoid null value '||'
    // JSON.parse(localStorage.getItem(LOCAL_STORAGE_USER_DATA) || "");
    if(!userData)
      return;
    const loadedUserData = new User(
      userData.email,
      userData.id,
      userData._token,
      userData._tokenExpirationDate);
    console.log({loadedUserdata:{...loadedUserData},isValid:loadedUserData.token});
    if(!loadedUserData)
      return;
    if(loadedUserData.token){
      this.userBeaviorSubject.next(loadedUserData);
      this.autoLogout(userData._tokenExpirationDate.getTime() - (new Date()).getTime())
    }
        
  }

   autoLogout(expireDuration : number){
    console.log({expireDurationAutoLogOut:expireDuration});
    this.tokenIdExpireLogoutTimeout = setTimeout(()=>{
      this.logout();
    },expireDuration);
   }

  private handleErrorResponse(errorRes:HttpErrorResponse){
    let errorMsg = 'An Unknown error happen!';
          console.log({ errorRes: errorRes });
          if (!errorRes.error || !errorRes.error.error) {
            return throwError(() => {
              return errorMsg;
            });
          }
          switch (errorRes.error.error.message) {
            case 'EMAIL_EXISTS':
              errorMsg = 'This E-mail already exist!';
              break;
            case 'EMAIL_NOT_FOUND':
              errorMsg = 'this Email was not exist!'  
              break;
            case 'INVALID_PASSWORD':
              errorMsg = "this password not correct!";
              break; 
            case "INVALID_LOGIN_CREDENTIALS":
              errorMsg = "Username or Password not correct!";
              break; 
          }
          // new error object as 'new Error(msg)' will include stack value as more info for the error
          //return throwError(() =>{ new Error(errorMsg)});
          return throwError(() => {
            return errorMsg;
          });
  }

  private handleAuthResponse(resData:AuthResponse){
      //'+' meaning will convert string to number
      const expirationDate = new Date(new Date().getTime() + (+resData.expiresIn*1000));
      const user  = new User(resData.email, resData.localId, resData.idToken, expirationDate);
      this.userBeaviorSubject.next(user);
      localStorage.setItem(LOCAL_STORAGE_USER_DATA,JSON.stringify(user));
      this.autoLogout(+resData.expiresIn * 1000);    
  }
}
