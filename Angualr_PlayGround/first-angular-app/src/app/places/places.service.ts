import { Injectable, signal,inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import{map,catchError, throwError} from 'rxjs'
import { Place } from './place.model';

@Injectable({
  providedIn: 'root',
})
export class PlacesService {
  
  private http = inject(HttpClient);
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
    );
  }

  addPlaceToUserPlaces(placeId: string) {
  // to update userplaces json file in backend
  return this.http.put("http://localhost:3000/user-places", {placeId});
  }

  removeUserPlace(place: Place) {}

  private fetchPlaces(url:string,errorMessage:string){
   return  this.http.get<{places:Place[]}>(url)
    .pipe(
      map((data) => data.places),
      catchError((error) =>{
        console.log("catchError",error);
        return throwError(() =>  new Error(`${error.error} ${errorMessage}`));     
      })
    )

  }
}
