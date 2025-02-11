import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

import { HeaderComponent } from './header/header.component';
import { UsersComponent } from './users/users.component';

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  imports: [HeaderComponent, UsersComponent, RouterOutlet],
})
export class AppComponent {}

/*
-ng build
-npm run build //(will run 'ng build' under the hood)

CONS
  1-to optimize the code - bundle szie
  2-genrate output path 'dist\routing\browser'

#hosting on firebase "firbase.google.com"
-hosting
-DB

-npm intsall -g firebase-tools //on global system device
-init firebase //on local project path
>hosting:Configuration file for firebase hosting (select)

-firebase deploy //will push on firebase your output then genrate dummy URL domain createds

#MANUALL WAY FOR PREVIOUS STEPS#

-ng add @angular/fire
-ng deploy
  
*/
