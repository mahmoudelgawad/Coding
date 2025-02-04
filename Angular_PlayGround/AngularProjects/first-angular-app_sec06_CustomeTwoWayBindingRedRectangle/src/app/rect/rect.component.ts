import { Component, EventEmitter, Input, input, model, Output, output } from '@angular/core';

@Component({
  selector: 'app-rect',
  standalone: true,
  imports: [],
  templateUrl: './rect.component.html',
  styleUrl: './rect.component.css',
})
export class RectComponent {
  // Todo: Implement custom two-way binding

// @Input({required:true}) size!:{width:string, height:string};
// @Output() sizeChange = new EventEmitter();

// size = input.required<{width:string, height:string}>();
// sizeChange = output<{width:string, height:string}>();

size = model.required<{width:string, height:string}>();

  onReset() {
    // let updated = {width:'100', height:'100'};
    // this.size.update( v => updated);

    // another ways to use update function

    // this.size.update(current => {
    //   return {width:'100', height:'100'}
    // });

    this.size.update(current => {
      current.width='100';
      current.height='100';
      return current;
    });
    
  }
}
