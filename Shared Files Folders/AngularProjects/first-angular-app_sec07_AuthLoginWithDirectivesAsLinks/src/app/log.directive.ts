import { Directive, ElementRef, inject } from '@angular/core';

@Directive({
  selector: '[appLog]',
  standalone: true,
  host:{
    '(click)':'onClick()'
  }
})
export class LogDirective { // custome host directive, can use in import 'hostDirective:' or as attribute directive

  private elementRef = inject(ElementRef); //get the curent element that applied on that directive
  constructor() { }

  onClick(){
    console.log('Click from LogDirective');
    console.log(this.elementRef.nativeElement);
  }

}
