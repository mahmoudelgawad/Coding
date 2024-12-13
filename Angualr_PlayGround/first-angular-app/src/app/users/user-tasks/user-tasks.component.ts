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

  private activatedRouter = inject(ActivatedRoute);
  userName='';

  ngOnInit(): void {
    console.log(this.activatedRouter); // to check how many invoked, called 1 time
    //subscribe on activatedRouter Observers
   let paramMapSubs =  this.activatedRouter.paramMap.subscribe({
      next:(param) => {
        this.userName = this.userService.users.find(u => u.id === param.get('userId'))?.name || '';
      } ,
      complete:undefined,
      error:undefined
    });
    this.destroyRef.onDestroy(() => paramMapSubs.unsubscribe());
  }

}
