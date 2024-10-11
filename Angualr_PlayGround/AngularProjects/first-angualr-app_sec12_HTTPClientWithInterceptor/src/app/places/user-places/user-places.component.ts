import { Component, DestroyRef, inject, OnInit, signal } from '@angular/core';
import { Place } from '../place.model';
import { PlacesContainerComponent } from '../places-container/places-container.component';
import { PlacesComponent } from '../places.component';
import { PlacesService } from '../places.service';

@Component({
  selector: 'app-user-places',
  standalone: true,
  templateUrl: './user-places.component.html',
  styleUrl: './user-places.component.css',
  imports: [PlacesContainerComponent, PlacesComponent],
})
export class UserPlacesComponent {


  isLoading = signal(true);
  errorDetails = signal(undefined);
  private placesService = inject(PlacesService);
  places = this.placesService.loadedUserPlaces;
  private destroyRef = inject(DestroyRef);
  // constructor(private client: HttpClient){}

ngOnInit(): void {
  const httpSubsObj = this.placesService.loadUserPlaces()
  .subscribe({
    // will use the services readonly signal variable "loadedUserPlaces" directly instead
    /*next: (data) =>{     
     this.places.set(data);
    },*/
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

 onRemoveplace(place:Place){
  const subsObj = this.placesService.removeUserPlace(place).subscribe();
  this.destroyRef.onDestroy(() => {subsObj.unsubscribe()});
 }


}
