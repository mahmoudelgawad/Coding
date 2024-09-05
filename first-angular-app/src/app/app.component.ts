import { Component, OnInit } from '@angular/core';
import { interval } from 'rxjs';

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit {
value:number = 0
  ngOnInit(){
    
    interval(1000).subscribe({
      next:(value) => console.log(value)
    });

    // setInterval(() => {
    //   console.log(this.value++);
    // }, 1000);
  }
}
