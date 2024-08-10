import { Directive, effect, inject, input, TemplateRef, ViewContainerRef } from '@angular/core';
import { Permission } from './auth.model';
import { AuthService } from './auth.service';

@Directive({
  selector: '[appAuth]',
  standalone: true
})
export class AuthDirective { //  custome stractural  directive
  userType = input.required<Permission>({alias:'appAuth'});
  private authService = inject(AuthService);

  private templateRef = inject(TemplateRef); // point to elements like '<P>' inside <ng-template>
  private viewContainerRef = inject(ViewContainerRef); // point to <ng-template>

  constructor() { 
    effect(() => {      //subscribe on changes for signal
      if(this.authService.activePermission() === this.userType()){
        this.viewContainerRef.createEmbeddedView(this.templateRef);
        //console.log("Show the Element ADMIN !");
      }
      else{
        this.viewContainerRef.clear();
        //console.log("Don't Show the Element");
      }
    });
  }

}
