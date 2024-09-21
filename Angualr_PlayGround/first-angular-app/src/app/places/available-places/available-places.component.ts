import { Component, DestroyRef, inject, OnInit, signal } from '@angular/core';

import { Place } from '../place.model';
import { PlacesComponent } from '../places.component';
import { PlacesContainerComponent } from '../places-container/places-container.component';
import { HttpClient, provideHttpClient } from '@angular/common/http';
import { catchError, map } from 'rxjs';

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
  isLoading = signal(true);
  errorDetails = signal(undefined);
  private http = inject(HttpClient);
  private destroyRef = inject(DestroyRef);
  // constructor(private client: HttpClient){}

ngOnInit(): void {
  let httpSubsObj = this.http.get<{places:Place[]}>("http://localhost:3000/places",{
    //headers:{'acceptMyCustom':'sdsd'},
    //observe:"events",
    //observe:"response"
  })
  .pipe(
    map((data) => data.places),
    catchError((error) =>{
      console.log("PipeCatchErrorOperator: Hello Error !");
      console.log("catchError",error);
      throw new Error(`${error.error} ::PipeCatchErrorOperator::`)
    })
  )
  .subscribe({
    next: (data) =>{     
      //observe:"response"
      //console.log(data.body?.places);

      //observe:"events"
      //console.log(data);
     this.places.set(data);
    },
   error:(error) =>{
      this.errorDetails.set(error);
      console.log(error);
   },
   complete:() => {
    this.isLoading.set(false);
   }
  });

  this.destroyRef.onDestroy(()=>{
    httpSubsObj.unsubscribe();
  });

 }

 onSelectPlace(selectedPlace:Place){
  // to update userplaces json file in backend
  this.http.put("http://localhost:3000/user-places",{placeId:selectedPlace.id})
  .subscribe({
    next:(data) => console.log(data),
  })
 }

 
}
