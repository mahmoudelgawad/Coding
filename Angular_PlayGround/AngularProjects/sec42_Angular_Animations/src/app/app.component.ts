import { animate, group, keyframes, state, style, transition, trigger } from '@angular/animations';
import { Component } from '@angular/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterOutlet } from '@angular/router';

const NORMAL_STATE = 'normal';
const HIGHLIGHTED_STATE = 'highlighted';
const SHRINK_STATE = 'shrink';

@Component({
  selector: 'app-root',
  standalone: true,
  //#removed after added 'providAnimations()' in 'main.ts'
  //imports: [BrowserAnimationsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  //#array of triggers (on html element with states and transitions) ,
  //# which apply methods as 'style()' 'animate()'
  animations:[
    trigger('divAnim',[
      state(NORMAL_STATE,
            style({
              'background-color':'red',
              transform:'translateX(0)'
      })),
      state(HIGHLIGHTED_STATE,style({
        'background-color':'blue',
        transform:'translateX(100px)'        
      })),
      transition(`${NORMAL_STATE} => ${HIGHLIGHTED_STATE}`,animate(300)),
      //#if we want can ignored after using '<=>' as above, but if same animate number
      transition(`${HIGHLIGHTED_STATE} => ${NORMAL_STATE}`,animate(800))
    ]),

    trigger('divAnimShrink',[
      state(NORMAL_STATE,
            style({
              'background-color':'red',
              transform:'translateX(0) scale(1)'
      })),
      state(HIGHLIGHTED_STATE,style({
        'background-color':'blue',
        transform:'translateX(100px) scale(1)'        
      })),
      state(SHRINK_STATE,style({
        'background-color':'green',
        transform:'translateX(0) scale(0.5)'
      })),
      transition(`${NORMAL_STATE} <=> ${HIGHLIGHTED_STATE}`,animate(300)),
      transition(`${SHRINK_STATE} <=> *`,[
        style({'background-color':'orange'}),
        animate(1000,style({'border-radius':'50px'})),
        animate(500)
      ]), 
    ]),

    trigger('list1',[
      state('in',style({
        opacity:1,
        transform:'translateX(0)'
      })),
      //#for adding items or init data
      transition('void => *',[
        style({
              opacity:0,
              transform:'translateX(-100px)'}),
        animate(300)
        ]),
      //#for deleting items
      transition('* => void',[
        //#should 'animate()' first set before style()  , or even add style({}) with 'animate()' itself
        animate(300),
        style({'background-color':'red',transform:'translateX(100px)',opacity:0}),
        ])
    ]),

    trigger('list2',[
      state('in',style({
        opacity:1,
        transform:'translateX(0)'
      })),
      //#for adding items or init data
      transition('void => *',[
        animate(1000,keyframes([
          style({transform:'translateX(-100px)',opacity:0,offset:0}),
          style({transform:'translateX(-50px)',opacity:0.5,offset:0.4}),
          style({transform:'translateX(0)',opacity:1,offset:1}),
        ]))
        ]),
        //#for deleting items
        transition('* => void',[
          group([
            animate(300,style({color:'red'})),
            animate(800,style({transform:'translateX(100px)',opacity:0}))
          ])
        ])

    ]),


  ]//end array of triggers,
  
})
export class AppComponent {
  divAnimState = NORMAL_STATE;
  divAnimShrinkState = NORMAL_STATE;
    list = ['Milk', 'Sugar', 'Bread'];

    onAnimate(){
      this.divAnimState === NORMAL_STATE ? this.divAnimState = HIGHLIGHTED_STATE : this.divAnimState = NORMAL_STATE;
      this.divAnimShrinkState === NORMAL_STATE ? this.divAnimShrinkState = HIGHLIGHTED_STATE : this.divAnimShrinkState = NORMAL_STATE;
    }
    onShrink(){
      this.divAnimShrinkState = SHRINK_STATE
    }

    onAdd(item:any) {
      this.list.push(item);
    }
    onDelete(item:any){
      let i = this.list.indexOf(item);
      this.list.splice(i,1);
    }
//# for angular animations callbacks  
    ondivAnimStart(event:any){
      console.log({fun:'ondivAnimStart',event:event});
    }
    ondivAnimEnd(event:any){
      console.log({fun:'ondivAnimEnd',event:event});
    }
}
