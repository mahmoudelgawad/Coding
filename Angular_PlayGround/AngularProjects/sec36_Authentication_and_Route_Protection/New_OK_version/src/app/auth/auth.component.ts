import { Component, inject } from "@angular/core";
import { NgForm } from "@angular/forms";
import { AuthService } from "./auth.service";
import { Observable } from "rxjs";
import { AuthResponse } from "./auth-response.model";
import { Router } from "@angular/router";

@Component({
    selector:"app-auth",
    templateUrl:'./auth.component.html'
})
export class AuthComponent{
  authService = inject(AuthService);
  router = inject(Router);
    isLoginMode = true;
    isLoading = false;
    error:string = "";

    onSwitchMode(){
      this.isLoginMode = !this.isLoginMode;  
    }

    onSubmit(form:NgForm){
      this.isLoading = true;
      const email = form.value.email;
      const password = form.value.password;
      let authObserver :Observable<AuthResponse>;

      if(this.isLoginMode){
        // login process
        //setTimeout(()=>{this.isLoading = false},4000);
        authObserver = this.authService.login(email,password);
      }else{ 
        authObserver = this.authService.signup(email,password);
      }
      authObserver.subscribe({
        next:(data) =>{
          console.log({authObserverData:data});
          this.isLoading = false;
          this.router.navigate(['/recipes']);
        },
        error:(errorMsg) => {
          //instead handling error source in pipeline catchError function of rxj
          //will handle here the final error message
          console.log({errorMsg:errorMsg});
          this.error = errorMsg;
          this.isLoading = false;
        },
        complete:undefined
      });
      console.log(form.value);
      form.reset();  
    }

}