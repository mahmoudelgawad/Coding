import { AfterContentInit,
   afterNextRender,
   afterRender,
   Component,
   contentChild,
   ContentChild,
   ElementRef,
   inject,
   input,
   ViewEncapsulation
   } from '@angular/core';

@Component({
  selector: 'app-control',
  standalone: true,
  imports: [],
  templateUrl: './control.component.html',
  styleUrl: './control.component.css',
  encapsulation: ViewEncapsulation.None,
  // another way to add click event on <P> element
  // host:{
  //   class:'control',
  //   '(click)':'onClick()'
  // }
})
export class ControlComponent implements AfterContentInit {
label = input.required<string>();
private el = inject(ElementRef);

// @ContentChild('input')
// private control?:ElementRef<HTMLInputElement | HTMLTextAreaElement>;

private control = contentChild<ElementRef<HTMLInputElement | HTMLTextAreaElement>>('input');

constructor(){
  afterRender(() =>{ // log with any changes anywhere in the app
    console.log("afterRender");
  });

  afterNextRender(() =>{ // log with any next changes anywhere in the app
    console.log("afterNextRender");
  });
}

ngAfterContentInit(): void {
  // you can access get element here instead ngOnInit undefined
}

onClick(){
  console.log('Clicked')
  console.log(this.el);
  console.log(this.control())
}

}
