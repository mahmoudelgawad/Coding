import { Component,Output, EventEmitter } from '@angular/core';
import {Features} from '../shared/constants';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html'
})
export class HeaderComponent {
 @Output() selectedFeatureEmitter = new EventEmitter<string>();
  readonly features = Features;
 onSelect(feature:string){
  this.selectedFeatureEmitter.emit(feature);
 }
}
