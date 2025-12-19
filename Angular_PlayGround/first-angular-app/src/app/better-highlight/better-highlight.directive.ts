import { Directive, ElementRef, HostBinding, HostListener, Input, OnInit, Renderer2 } from '@angular/core';

@Directive({
  selector: '[appBetterHighlight]'
})
export class BetterHighlightDirective implements OnInit {

  @HostBinding('style.backgroundColor') hostBackGroundColor:string;
  @Input() defaultColor:string = 'transparent';
  @Input() highlightColor:string = 'blue';
  constructor(private elementRef:ElementRef,private renderer :Renderer2) {

   }

  ngOnInit():void{
    //this.renderer.setStyle(this.elementRef.nativeElement,"background-color","blue");
    this.hostBackGroundColor = this.defaultColor;
  }

  @HostListener('mouseenter') onMouseOver(){
    //this.renderer.setStyle(this.elementRef.nativeElement,"background-color","red");
    // this.hostBackGroundColor = "red";
    this.hostBackGroundColor = this.highlightColor;
  }
  @HostListener('mouseleave') onMouseLeave(){
    //this.renderer.setStyle(this.elementRef.nativeElement,"background-color","blue");
    // this.hostBackGroundColor = "transparent";
    this.hostBackGroundColor = this.defaultColor;
  }
}
