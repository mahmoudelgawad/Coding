import { Component, inject } from '@angular/core';

import { CounterService } from '../counter.service';
import { Store } from '@ngrx/store';
import { decrementAction, incrementAction } from '../store/counter.actions';

@Component({
  selector: 'app-counter-controls',
  templateUrl: './counter-controls.component.html',
  styleUrls: ['./counter-controls.component.css'],
  standalone: true,
})
export class CounterControlsComponent {

  store = inject(Store);
  constructor(private counterService: CounterService) {}

  increment() {
    //# ignored for using ngrx store instead
    //this.counterService.increment();
    
    this.store.dispatch(incrementAction({valueRate:1}));
  }

  decrement() {
    //#ignored
    //this.counterService.decrement();
    
    this.store.dispatch(decrementAction({valueRate:1}));
  }
}
