import { inject, Injectable } from "@angular/core";
import { ActivatedRouteSnapshot, CanActivate, GuardResult, MaybeAsync, Router, RouterStateSnapshot } from "@angular/router";
import { map, Observable, take, tap } from "rxjs";
import { AuthService } from "./auth.service";

@Injectable({providedIn:"root"})
export class AuthGuard implements CanActivate{

    authService = inject(AuthService);
    router = inject(Router);
    // canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean | Promise<boolean> | Observable<boolean>
    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot):MaybeAsync<GuardResult>
    {
        return this.authService.userBeaviorSubject.pipe(
            take(1),
            map(user =>{
                const isAuth = !!user; //'!!' convert object to boolean
                if(isAuth)
                    return true;
                //URLTree vs navigate to avoid multiple redirect and not interfere each other 
                return this.router.createUrlTree(['/auth']);
            }),

            // Another simple way
            /*
            map(user =>{
                return !!user; //'!!' convert object to boolean
            }),
            tap(isAuth =>{
                if(!isAuth)
                    this.router.navigate(['/auth']);
            })
                */
        );
    }
}