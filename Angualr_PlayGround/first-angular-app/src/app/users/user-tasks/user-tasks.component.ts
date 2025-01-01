import { Component, computed, DestroyRef, inject, input, OnInit } from '@angular/core';
import { UsersService } from '../users.service';
import { ActivatedRoute, ActivatedRouteSnapshot, ResolveFn, RouterLink, RouterOutlet, RouterStateSnapshot } from '@angular/router';
import { resolvedUserTasksResolver } from '../../tasks/tasks.component';

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

  staticMessage = input<string>();
  resolvedUserName = input<string>();

  ngOnInit(): void {
    console.log({staticMessage:this.staticMessage()});

    //ActivatedRoute object provide information about current url params  or page
    console.log(this.activatedRoute); // here to check how many invoked, called 1 time

    // snapshot provide same data but, when component update or url/page will not get the new values
    // snapshot properteis not observable, so it easy quick access for values
    
    console.log(this.activatedRoute.snapshot);
    console.log(this.activatedRoute.snapshot.paramMap.get('userId'));
    //subscribe on activatedRoute Observers, changes stream data every selected user changed
   let paramMapSubs =  this.activatedRoute.paramMap.subscribe({
      next:(param) => {
        this.userName = this.userService.users.find(u => u.id === param.get('userId'))?.name || '';
      },
      complete:undefined,
      error:undefined
    });

    //subscribe on activatedRoute 'data', other way to get URL params
    let dataSubs = this.activatedRoute.data.subscribe({
      next:(data) =>{
        console.log({data:data});
      },
      complete:undefined,
      error:undefined
    });
    this.destroyRef.onDestroy(() => paramMapSubs.unsubscribe());
  }

}

//second way to get parameter value from URL using resolver fun and ActivatedRouteSnapShot
// that not conatin observers, just static values
export const resolvedUserNameResolver : ResolveFn<string> = (
  activatedRouteSnapShot : ActivatedRouteSnapshot,
  routeStatesSnapShot : RouterStateSnapshot
) =>{
  const userService = inject(UsersService);
  let userIdParam = activatedRouteSnapShot.paramMap.get('userId');
  let resolvedUserName = userService.users.find(u => u.id === userIdParam)?.name || '';
  return resolvedUserName;
}

export const titleResolver:ResolveFn<string> =(
  activatedRouteSnapshot, //you can just define argument wihtout decalre the type
  routerStateSnapshot) =>{
    return resolvedUserNameResolver(activatedRouteSnapshot,routerStateSnapshot) + "\'s Tasks";
  }
