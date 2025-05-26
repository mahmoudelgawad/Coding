import { Component } from '@angular/core';
import { AnalyticsService } from 'src/app/shared/analytics.service';
import { HighlightDirective } from 'src/app/shared/highlight.directive';
//import { SharedModule } from 'src/app/shared/shared.module';

@Component({
  // will raise error if it still exist in AppModule 'NgModule' [providers]
  // but will ok if added in AppModule 'NgModule' [Imports], for global usage
  standalone:true, 
  //to make SharedModule visible here also as AppModule
  //not used sharedmodule after let highlight component as standalone
  //imports:[SharedModule],
  imports:[HighlightDirective],
  providers:[AnalyticsService],
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css'],
})
export class DetailsComponent {
  constructor(private analyticsService: AnalyticsService) {}

  onClick() {
    this.analyticsService.registerClick();
  }
}
