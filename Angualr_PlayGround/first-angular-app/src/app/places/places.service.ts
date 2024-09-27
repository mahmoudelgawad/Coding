import { Injectable, signal,inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import{map,catchError, throwError, tap} from 'rxjs'
import { Place } from './place.model';

@Injectable({
  providedIn: 'root',
})
export class PlacesService {
  
  private httpClient = inject(HttpClient);
  private userPlaces = signal<Place[]>([]);

  loadedUserPlaces = this.userPlaces.asReadonly();

  loadAvailablePlaces() {
    return this.fetchPlaces("http://localhost:3000/places",
      "::PipeCatchErrorOperator::"
    );
  }

  loadUserPlaces() {
    return this.fetchPlaces("http://localhost:3000/user-places",
      "::PipeCatchErrorOperator::"
    ).pipe( // call pipe second time after fetch method return Observable object
      tap({ // tap operator do like subscribe, looks deprecated! in next rxjs version 8.0
        next:(palces) => this.userPlaces.set(palces)
      }),
    );
  }

  addPlaceToUserPlaces(place: Place) {
    const prevUserPlaces = this.userPlaces();
    if(!prevUserPlaces.some((e) => e.id === place.id)){
       this.userPlaces.update((prev) => [...prev, place]);
    }
   
  // to update userplaces json file in backend
  return this.httpClient.put("http://localhost:3000/user-places", {placeId:place.id})
  .pipe(
    catchError((error) =>{
      this.userPlaces.set(prevUserPlaces);
      return throwError(() => { new Error("Failed to load users places")})
    }),
   );
  }

  removeUserPlace(place: Place) {}

  private fetchPlaces(url:string,errorMessage:string){
   return  this.httpClient.get<{places:Place[]}>(url)
    .pipe(
      map((data) => data.places), // return only Place[]
      catchError((error) =>{
        console.log("catchError",error);
        return throwError(() =>  new Error(`${error.error} ${errorMessage}`));     
      })
    )
  }


}
