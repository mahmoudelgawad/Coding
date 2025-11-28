import { Component, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-game-control',
  templateUrl: './game-control.component.html',
  styleUrl: './game-control.component.css'
})
export class GameControlComponent {

@Output() numberEventEmitter =  new EventEmitter<number>();
 intervalObj;
 number:number = 0;

  onStart(){
   this.intervalObj =  setInterval(() =>{
    this.numberEventEmitter.emit(this.number);
      ++this.number;
    },1000);
  }

  onPause(){
    clearInterval(this.intervalObj);
  }
}
