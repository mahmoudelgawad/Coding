import { Directive } from '@angular/core';

@Directive({
  selector: '[appAuth]',
  standalone: true
})
export class AuthDirective { //  custome stractural  directive

  constructor() { }

}
