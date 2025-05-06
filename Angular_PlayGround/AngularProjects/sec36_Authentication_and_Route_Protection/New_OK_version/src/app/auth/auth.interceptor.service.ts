import { HttpEvent, HttpHandler, HttpInterceptor, HttpParams, HttpRequest } from "@angular/common/http";
import { inject, Injectable } from "@angular/core";
import { exhaustMap, Observable, take } from "rxjs";
import { AuthService } from "./auth.service";

@Injectable({
    providedIn:'root'
})
export class AuthInterceptorService implements HttpInterceptor{

     authService = inject(AuthService);
    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        //pipe on stored 'user' data in BehaviorSubject
        //at the end operator will return modified HttpRequest
       return this.authService.userBeaviorSubject.pipe(
           // insure take single 1 emit value 
            take(1),
            //will wait the internal observer to complete before emit the value
            exhaustMap(user =>{
                //in case signin , so no user data saved yet
                if(!user)
                    return next.handle(req);
                
                const modifiedRequest = req.clone({
                    params:new HttpParams()
                            .set('auth',user && user.token ? user.token : "")
                });
                return next.handle(modifiedRequest); // internal observable
            }),
        );
    }
}