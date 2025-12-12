import { Component } from '@angular/core';
import {Features} from '../app/shared/constants';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'app';
  readonly features = Features;
  selectedFeature = Features.Recipes;
  onSelectedFeature(feature){
    this.selectedFeature = feature;
  }
}
