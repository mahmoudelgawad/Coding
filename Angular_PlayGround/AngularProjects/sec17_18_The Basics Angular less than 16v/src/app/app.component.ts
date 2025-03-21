import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
  /*styles:[`
     h3{
       color: darkblue;
     }
    `]*/
})
export class AppComponent {
  title = 'first-angular-app';
  username='';
  isShowSecret = false;
  logs:Date[]=[];

  onToggleDetails(){
    this.isShowSecret = true;
    // this.logs.push(this.logs.length +1);
    this.logs.push(new Date());
  }
}
