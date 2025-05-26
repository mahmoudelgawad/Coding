import { enableProdMode, importProvidersFrom } from '@angular/core';
import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

//import { AppModule } from './app/app.module';
import { environment } from './environments/environment';
import { bootstrapApplication } from '@angular/platform-browser';
import { AppComponent } from './app/app.component';
import { AnalyticsService } from './app/shared/analytics.service';
import { RouterModule } from '@angular/router';
import { AppRoutingModule } from './app/app-routing.module';

if (environment.production) {
  enableProdMode();
}

bootstrapApplication(AppComponent,{
  //#if you want make service provided global in the entire Application
  providers:[
    // AnalyticsService,
    importProvidersFrom(AppRoutingModule)
  ]
});

//# after AppComponent to standalone 
/*
platformBrowserDynamic().bootstrapModule(AppModule)
  .catch(err => console.error(err));
  */
