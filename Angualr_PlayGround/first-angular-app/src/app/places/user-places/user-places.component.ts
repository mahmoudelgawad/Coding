import { Component, DestroyRef, inject, OnInit, signal } from '@angular/core';
import { Place } from '../place.model';
import { PlacesContainerComponent } from '../places-container/places-container.component';
import { PlacesComponent } from '../places.component';

import { HttpClient, provideHttpClient } from '@angular/common/http';
import { catchError, map } from 'rxjs';

@Component({
  selector: 'app-user-places',
  standalone: true,
  templateUrl: './user-places.component.html',
  styleUrl: './user-places.component.css',
  imports: [PlacesContainerComponent, PlacesComponent],
})
export class UserPlacesComponent {

  places = signal<Place[] | undefined>(undefined);
  isLoading = signal(true);
  errorDetails = signal(undefined);
  private http = inject(HttpClient);
  private destroyRef = inject(DestroyRef);
  // constructor(private client: HttpClient){}

ngOnInit(): void {
  let httpSubsObj = this.http.get<{places:Place[]}>("http://localhost:3000/user-places",{
    //headers:{'acceptMyCustom':'sdsd'},
    //observe:"events",
    //observe:"response"
  })
  .pipe(
    map((data) => data.places),
    catchError((error) =>{

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


}
