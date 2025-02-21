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

/* 
#for enable SSR (Server Side Rendered) with NodeJs server + Express
CLI> ng new --ssr   //for new project from scratch
CLI> ng add @angualr/ssr    //adding ssr library for exist project

#you will find added parts (SEE MyNotes folder for screenshots) '\MyNotes\after add-enable angural ssr package'
-in file 'angualr.json'
  "ssr":{
  "entery":"server.ts"
  }
  
- + "./src/server.ts"  
- + "./src/main.server.ts" // Nodejs server + express code
- + "app.config.server.ts" 

# after build again
-you will find two output folders
 1- 'dist/routing/browser'
 2- 'dist/routing/server'
-then you can run 'npm run serve:ssr:routing'
*/
