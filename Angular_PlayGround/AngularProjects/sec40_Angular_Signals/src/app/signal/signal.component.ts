import { NgFor } from '@angular/common';
import { Component, computed, effect, signal } from '@angular/core';

@Component({
  selector: 'app-signal',
  templateUrl: './signal.component.html',
  standalone: true,
  imports: [NgFor],
})
export class SignalComponent {
  actions = signal<string[]>([]);
  counter = signal(0);
  //genrate value from other signals
  doubleCounter = computed(() => this.counter() * 2); 
  
  constructor(){
    // process code with signals
    effect(() => console.log(this.counter()));
  }

  increment() {
    //this.counter++;
    // this.counter.update((old) => ++old);
    this.counter.update((old) => old+1);
    this.actions.update((oldActions) => [...oldActions,'INCREMENT']);
  }

  decrement() {
    //this.counter--;
    // this.counter.update((old) => --old);
    this.counter.update((old) => old-1);
    this.actions.update((oldActions) => [...oldActions,'DECREMENT']);
  }
}
