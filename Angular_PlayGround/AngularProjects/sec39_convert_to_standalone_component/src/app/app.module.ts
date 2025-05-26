//# to be deprecated after change root AppComponent to standalone and changes in 'main.ts' file

/*
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
//import { SharedModule } from './shared/shared.module';
import { DetailsComponent } from './welcome/details/details.component';
import { WelcomeComponent } from './welcome/welcome.component';

@NgModule({
  //declarations: [AppComponent, WelcomeComponent],
  //#after 'WelcomeComponent' to standalone and moved to [imports]
  declarations: [AppComponent],

  //#after make 'DetailsComponent' globbaly satndalone, so adding singleton component here
  //imports: [BrowserModule, SharedModule, DetailsComponent]
  //#after  'SharedModule' to standalone
  //imports: [BrowserModule, DetailsComponent],
  //#after 'WelcomeComponent' to standalone 
  imports: [BrowserModule, DetailsComponent,WelcomeComponent],  

  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
*/