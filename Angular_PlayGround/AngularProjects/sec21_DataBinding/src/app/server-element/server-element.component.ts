import { Component, Input, ViewEncapsulation,
  OnChanges,
  SimpleChanges, 
  OnInit,
  DoCheck, 
  AfterContentInit,
  AfterContentChecked,
  AfterViewInit,
  AfterViewChecked,
  OnDestroy,
  ViewChild,
  ElementRef,
  ContentChild,
  } from '@angular/core';

@Component({
  selector: 'app-server-element',
  templateUrl: './server-element.component.html',
  styleUrl: './server-element.component.css',
  //#None: affect on all as native.
  //#ShadowDome: ecapsulate with css clean.
  //#Emulated: encapsulate with css with special attribute name on DOM '_ngcontent-ng-c170938029' 
  encapsulation: ViewEncapsulation.Emulated 
})
export class ServerElementComponent implements 
  OnChanges,
  OnInit,
  DoCheck,
  AfterContentInit,
  AfterContentChecked,
  AfterViewInit,
  AfterViewChecked,
  OnDestroy
  {
  //#element as JSON (JavaScript object notation)

  //#@Input() to mapping passing from outside component
  //@Input() element:{type:string, name:string, content:string};

  //#@Input() with aliase name to mapping passing from outside component
  @Input('serverElement') element:{type:string, name:string, content:string};

  @Input() servName:string;

  //# mandatory in ng 9.0+ '{static:true}' if access from ngOnInit
  @ViewChild('header',{static:true}) header:ElementRef;

  //#content child, because it's injected from outside, not part of current view
  @ContentChild('ngcontentparagraph',{static:true}) ngcontentparagraph : ElementRef;

  //#local variable
  localViewTitle="we are in server-element component";

  constructor(){
    console.log('constructor');
  }

  ngOnChanges(changes: SimpleChanges): void {
    console.log('ngOnchanges');
    console.log({changes:changes});
  }

  ngOnInit(): void {
    console.log('ngOnInit');

    //# will fire ngDoCheck, ngAfterContentChecked, ngAfterViewChecked
    setTimeout(() => this.localViewTitle = "Title Changes",6000);

    //# textContent will empty here both view and content
    console.log({'headerContentOnInit':this.header.nativeElement.textContent});
    console.log({'ngcontentparagraphOnInit':this.ngcontentparagraph.nativeElement.textContent}); 
  }

  ngDoCheck(){
    console.log('ngDoCheck');
  }

  ngAfterContentInit(){
    console.log("ngAfterContentInit");
    console.log({'ngcontentparagraphAfterContentInit':this.ngcontentparagraph.nativeElement.textContent});
  }

  ngAfterContentChecked(){
    console.log("ngAfterContentChecked");
  }

  ngAfterViewInit(){
    console.log("ngAfterViewInit");
    console.log({'headerContentAfterViewInit':this.header.nativeElement.textContent});
    console.log({'ngcontentparagraphAfterViewInit':this.ngcontentparagraph.nativeElement.textContent});
  }

  ngAfterViewChecked(){
    console.log("ngAfterViewChecked");
  }

  ngOnDestroy(): void {
    console.log("ngOnDestroy");
  }

}
