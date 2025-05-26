import { Component } from '@angular/core';
import { DetailsComponent } from './details/details.component';

  /*when try add standalone component 'DetailsComponent' here
    there wase error, so we added as  globally in app.module instead, 'with imports'
    */
/*
@Component({
  //imports:[DetailsComponent], // error :imports only available in standalone components
  selector: 'app-welcome',
  templateUrl: './welcome.component.html'
})
*/

//after convert to standalone, so will removed from 'AppModule' [declarations]
@Component({
  standalone:true,
  imports:[DetailsComponent],
  selector: 'app-welcome',
  templateUrl: './welcome.component.html'
})
export class WelcomeComponent {}
