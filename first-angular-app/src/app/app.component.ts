import { Component, computed, DestroyRef, effect, inject, OnInit, signal } from '@angular/core';
import { toObservable } from '@angular/core/rxjs-interop';
import { interval,map } from 'rxjs';

//Observables
//has no initial values
//Observables is 'values over the time" pipe line emits values
//greate in management events and stream data


//Signals
//Signal have intial value
//Signal is 'values in container" you can ask or check values any time 'signalValue()'
//good in management application state

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit {

destroy= inject(DestroyRef);

//value:number = 0;
signalValue = signal(0);
signalDoubleValue = computed(() => this.signalValue() * 2 );

//countClick:number = 0;
signalCountClick = signal(0);
observableCountClick = toObservable(this.signalCountClick);

constructor(){
  // effect run with each signal object updates
  effect(() =>{
    console.log(`signalValue = ${this.signalValue()}`);
    console.log(`signalDoubleValue = ${this.signalDoubleValue()}`);    

    //console.log(`clicked on button ${this.countClick} times.`);
    console.log(`clicked on button ${this.signalCountClick()} times.`);

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
