import { Directive, effect, inject, input } from '@angular/core';
import { Permission } from './auth.model';
import { AuthService } from './auth.service';

@Directive({
  selector: '[appAuth]',
  standalone: true
})
export class AuthDirective { //  custome stractural  directive
  userType = input.required<Permission>({alias:'appAuth'});
  private authService = inject(AuthService);
  constructor() { 

    effect(() => {      //subscribe on changes for signal
      if(this.authService.activePermission() === this.userType()){
        console.log("Show the Element ADMIN !");
      }
      else{
        console.log("Don't Show the Element");
      }
    });

  }

}
