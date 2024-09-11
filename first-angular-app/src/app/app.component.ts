import { Component, computed, DestroyRef, effect, inject, OnInit, signal } from '@angular/core';
import { toObservable, toSignal } from '@angular/core/rxjs-interop';
import { interval, map, Observable } from 'rxjs';

//Observables
//has no initial values
//Observables is 'values over the time" pipe line emits values from stream data
//greate in management events and stream data


//Signals
//Signal have intial value
//Signal is 'values in container" you can ask or check values any time 'signalValue()'
//good in management application state

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  styleUrl:'./app.component.css'
})
export class AppComponent implements OnInit {
  isBlue:boolean = true;

destroy= inject(DestroyRef);

//value:number = 0;
signalValue = signal(0);
signalDoubleValue = computed(() => this.signalValue() * 2 );

//countClick:number = 0;
signalCountClick = signal(0);
observableCountClick$ = toObservable(this.signalCountClick);

//every 1 second emit value
observableInterval$ = interval(1000);
//first item is undefined because observable not have initial value
signalInterval = toSignal(this.observableInterval$,{initialValue:undefined});


//custom observable from scratch
customObservable$ = new Observable((subscriber) =>{
  setInterval(() =>{
    console.log("Emitt Value");
    //emitt next value every 2 sec
    subscriber.next({message:'new value'});
  },2000);
});


constructor(){
  // effect run with each signal object updates
/*  effect(() =>{
    console.log(`signalValue = ${this.signalValue()}`);
    console.log(`signalDoubleValue = ${this.signalDoubleValue()}`);    
  
    //console.log(`clicked on button ${this.countClick} times.`);
    console.log(`clicked on button ${this.signalCountClick()} times.`);

  });
  */
 let observableSubsObj = this.observableCountClick$.subscribe({
  next:(value) =>{
    //log every change set or update on signalCountClick object 
    //instead log with effect method on constructor
         console.log(`observableCountClick value is ${value}`);},
  error:undefined,
  complete:undefined
});

let customObservableSubsObj = this.customObservable$.subscribe((val) =>{console.log(val)});

 this.destroy.onDestroy(() =>{
  observableSubsObj.unsubscribe();
  customObservableSubsObj.unsubscribe();
 });
 
}

  ngOnInit(){
  // using Observable
  //  let intervalSubscribe =  interval(1000).pipe(
  //   map((val) => val * 2) //map operator
  //  )
  //  .subscribe({
  //     next:(value) => console.log(value),
  //     error:undefined,
  //     complete:undefined
  //   });

  //   this.destroy.onDestroy(() =>{
  //     intervalSubscribe.unsubscribe();
  //   });


    setInterval(() => {
      //console.log(this.value++);
      this.signalValue.update((prevVal) => ++prevVal);
    }, 1000);

  }

  incrementCount(){
    //this.countClick = this.countClick + 1;
    this.signalCountClick.update((prev) => prev + 1);
  }

}
