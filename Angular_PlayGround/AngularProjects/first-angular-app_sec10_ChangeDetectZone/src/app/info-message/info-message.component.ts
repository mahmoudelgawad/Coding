import { Component } from '@angular/core';

@Component({
  selector: 'app-info-message',
  standalone: true,
  imports: [],
  templateUrl: './info-message.component.html',
  styleUrl: './info-message.component.css',
})
export class InfoMessageComponent {
  get debugOutput() {
    console.log('[InfoMessages] "debugOutput" binding re-evaluated.');
    return 'InfoMessage Component Debug Output';
    //that will cause error because , Develeopment mode detect changes twice 
    // and the second time will return different value than the first one
    //Angualr Dev mode : detect unwanted changes 
    //return Math.random();
  }

  onLog() {
    console.log('Clicked!');
  }
}
