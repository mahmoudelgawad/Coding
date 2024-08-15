import { DatePipe, DecimalPipe } from '@angular/common';
import { Component } from '@angular/core';
import { TempraturePipe } from './Temprature.pipe';
import { SortPipe } from './sort.pipe';

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  imports:[DatePipe, DecimalPipe, TempraturePipe, SortPipe]
})
export class AppComponent {
  currentDate = new Date();
  currentTemperaturs = {
    berlin: 4.2749812,
    newYork: 18.1214,
    paris: 72.1209001,
    chicago: 65.0775238,
    gaza:60.2486345
  };

  historicTemperatures = [
    25, 37, 19, -4, 28, 21, 19, 28, 33, 31, 9, 11, 5, -12, -5,
  ];

  constructor(){
    // ascending order instead use sort pipe
    //this.historicTemperatures.sort((a,b) => a>b ? 1 : -1);
  }

  onReset(index: number) {
   
    //this will no change value or even sorted pipe because we change just element
    // to make sorted pipe run with any changes should put on its decorator {pure:false}
    //as impure pipe
    this.historicTemperatures[index] = 18;

    // so we will change the reference instead of, if the sorted pipe pure
    // let temp = [...this.historicTemperatures];
    // temp[index] = 18;
    // this.historicTemperatures = temp;
  
  }
}
