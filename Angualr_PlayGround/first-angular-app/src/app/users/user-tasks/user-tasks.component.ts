import { Component, computed, DestroyRef, inject, input, OnInit } from '@angular/core';
import { UsersService } from '../users.service';
import { ActivatedRoute, RouterLink, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-user-tasks',
  standalone: true,
  imports:[RouterOutlet,RouterLink],
  templateUrl: './user-tasks.component.html',
  styleUrl: './user-tasks.component.css',
})
export class UserTasksComponent implements OnInit {
  private userService = inject(UsersService);
private destroyRef = inject(DestroyRef);

  //using signal, with auto param mapping, via app providers 'withComponentInputBinding()'
  // userId = input.required<string>();
  // userName=computed(
  //   () => this.userService.users.find(u => u.id === this.userId())?.name
  // );

  private activatedRoute = inject(ActivatedRoute);
  userName='';

  ngOnInit(): void {
    //ActivatedRoute object provide information about current url params  or page
    console.log(this.activatedRoute); // here to check how many invoked, called 1 time

    // snapshot provide same data but, when component update or url/page will not get the new values
    // snapshot properteis not observable, so it easy quick access for values
    
    console.log(this.activatedRoute.snapshot);
    console.log(this.activatedRoute.snapshot.paramMap.get('userId'));
    //subscribe on activatedRoute Observers
   let paramMapSubs =  this.activatedRoute.paramMap.subscribe({
      next:(param) => {
        this.userName = this.userService.users.find(u => u.id === param.get('userId'))?.name || '';
      } ,
      complete:undefined,
      error:undefined
    });
    this.destroyRef.onDestroy(() => paramMapSubs.unsubscribe());
  }

}
