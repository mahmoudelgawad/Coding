import { Component, DestroyRef, inject, OnInit, signal } from '@angular/core';

import { Place } from '../place.model';
import { PlacesComponent } from '../places.component';
import { PlacesContainerComponent } from '../places-container/places-container.component';
import { HttpClient, provideHttpClient } from '@angular/common/http';

@Component({
  selector: 'app-available-places',
  standalone: true,
  templateUrl: './available-places.component.html',
  styleUrl: './available-places.component.css',
  imports: [PlacesComponent, PlacesContainerComponent],
  //error because return EnvironemtnProvider, but need here Provider
  //providers:[provideHttpClient()]
})
export class AvailablePlacesComponent implements OnInit {
  places = signal<Place[] | undefined>(undefined);
  private http = inject(HttpClient);
  private destroyRef = inject(DestroyRef);
  // constructor(private client: HttpClient){}
ngOnInit(): void {
  let httpSubsObj = this.http.get<{places:Place[]}>("http://localhost:3000/places",{}).subscribe((data) =>{
    console.log(data)
  });
  this.destroyRef.onDestroy(()=>{
    httpSubsObj.unsubscribe();
  });
}
}
