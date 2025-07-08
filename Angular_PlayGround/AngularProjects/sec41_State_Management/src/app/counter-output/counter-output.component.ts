import { Component, OnDestroy, OnInit } from '@angular/core';
import { Observable, Subscription } from 'rxjs';

import { CounterService } from '../counter.service';
import { Store } from '@ngrx/store';
import { AsyncPipe } from '@angular/common';
import { counterDoubleSelector, counterSelector, counterTripleSelector } from '../store/counter.selectors';

@Component({
  selector: 'app-counter-output',
  templateUrl: './counter-output.component.html',
  styleUrls: ['./counter-output.component.css'],
  standalone: true,
  imports:[AsyncPipe]
})
// export class CounterOutputComponent implements OnInit, OnDestroy {
export class CounterOutputComponent{
  //counter = 0;
  //counterServiceSub?: Subscription;
  counter$ : Observable<number>;
  counterDouble$ : Observable<number>;
  counterTriple$ : Observable<number>;

 // constructor(private counterService: CounterService) {}
 constructor(private store : Store<{counter:number}>){
  //# matching the key name in 'main.ts' provider store
  //this.counter$ = store.select('counter');

  //# using multiple selectors
  this.counter$ = store.select(counterSelector);
  this.counterDouble$ = store.select(counterDoubleSelector);
  this.counterTriple$ = store.select(counterTripleSelector)
 }
/*
  ngOnInit(): void {
    this.counterServiceSub = this.counterService.counterChanged.subscribe(
      (newVal) => (this.counter = newVal)
    );
  }

  ngOnDestroy(): void {
    if (this.counterServiceSub) {
      this.counterServiceSub.unsubscribe();
    }
  }
    */
}
