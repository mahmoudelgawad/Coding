import { Component, DestroyRef, inject, OnDestroy, OnInit } from '@angular/core';
import { TimeInterval } from 'rxjs/internal/operators/timeInterval';

@Component({
  selector: 'app-server-status',
  standalone: true,
  imports: [],
  templateUrl: './server-status.component.html',
  styleUrl: './server-status.component.css'
})
// implement interfaces to force components with specific hooks methods
export class ServerStatusComponent implements OnInit {
  currentStatus : "online" | "offline" | "unknown" = "offline";
  private destroyRef = inject(DestroyRef);
  
  //private interval?: ReturnType<typeof setInterval>;

 constructor(){} 

 // use ngOnInit better after all component input initalized
  ngOnInit(){
    console.log("ngOnInit");
   const interval = setInterval(() => {
      const rnd= Math.random(); //0 ~ 0.99999999

      if(rnd < 0.5){
        this.currentStatus = "online";
      } else if(rnd < 0.9){
        this.currentStatus = "offline";
      }else {
        this.currentStatus = "unknown";
      }
    },5000);

    // another way to handle what should implement when destroy component
    this.destroyRef.onDestroy(() => clearInterval(interval));
  }

  ngAfterViewInit(){
    console.log("ngAfterViewInit");
  }

  // ngOnDestroy(): void {
  //   console.log("ngOnDestroy");
  //   clearInterval(this.interval);  
  // }
}
