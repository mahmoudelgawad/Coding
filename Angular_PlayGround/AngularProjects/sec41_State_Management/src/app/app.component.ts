import { Component, inject, OnInit } from '@angular/core';

import { CounterOutputComponent } from './counter-output/counter-output.component';
import { CounterControlsComponent } from './counter-controls/counter-controls.component';
import { Store } from '@ngrx/store';
import { initAction } from './store/counter.actions';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  standalone: true,
  imports: [CounterOutputComponent, CounterControlsComponent],
})
export class AppComponent implements OnInit {
  store  = inject(Store<{counter:number}>);
  ngOnInit(): void {
    this.store.dispatch(initAction());
  }
}
