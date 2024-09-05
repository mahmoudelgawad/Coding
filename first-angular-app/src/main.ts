import { bootstrapApplication } from '@angular/platform-browser';
// mean Zone.js ignored for detect changes
//specially when have setTimeOut Timer on change normal variable
// so use signal object instead to check changes during Zone.js ignored
//import { provideExperimentalZonelessChangeDetection } from '@angular/core';
import { AppComponent } from './app/app.component';


bootstrapApplication(AppComponent).catch((err) => console.error(err));
