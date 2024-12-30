import { Component, computed, DestroyRef, Inject, inject, input, OnInit, signal } from '@angular/core';

import { TaskComponent } from './task/task.component';
import { Task } from './task/task.model';
import { TasksService } from './tasks.service';
import { ActivatedRoute, ActivatedRouteSnapshot, ResolveFn, RouterLink, RouterStateSnapshot } from '@angular/router';

@Component({
  selector: 'app-tasks',
  standalone: true,
  templateUrl: './tasks.component.html',
  styleUrl: './tasks.component.css',
  imports: [TaskComponent, RouterLink]
})
export class TasksComponent  implements OnInit{
  private tasksService = inject(TasksService);
  private destroRef=inject(DestroyRef);
  private activatedRoute = inject(ActivatedRoute);

  userId=input.required<string>(); 

  //will input from itself via [queryParams], and auto input binding 
  // thanks for  'withComponentInputBinding()' in app.config
  
  // order = input<'asc'|'desc'>(); //we can use order as input

  //order?:'asc' |'desc'; //we can use order as variable

  order = signal<'asc'|'desc'>('desc');


  // userTasks: Task[] = [];
  userTasks = computed(() => this.tasksService.allTasks()
  .filter( t => t.userId === this.userId())
  .sort((a,b) => {
    if(this.order() === 'asc')
      return (a.id > b.id) ? 1 : -1;
    else
    return (a.id > b.id) ? -1 : 1; //for desc order
  }));

  resolvedUserTasks = input<Task[]>(); //filled by resolver function
  
  
  ngOnInit(): void {
  
   let paramsSubs= this.activatedRoute.queryParams.subscribe(
     {
      next:(params) => this.order.set(params['order']),
      complete:undefined,
      error:undefined
     });
     this.destroRef.onDestroy(()=>{paramsSubs.unsubscribe()});
  }
}

export const resolvedUserTasksResolver:ResolveFn<Task[]> = (
  activatedRouteSnapShot:ActivatedRouteSnapshot,
  routerStateSnapshot:RouterStateSnapshot) => {
    const order = activatedRouteSnapShot.queryParams['order']; //xxxx?order=desc
    const tasksService = inject(TasksService);
    const tasks = tasksService.allTasks().filter(
      t => t.userId === activatedRouteSnapShot.paramMap.get('userId')); //xxx/users/userId:/tasks
    
      if(order && order === 'asc'){
        tasks.sort((a,b) => (a > b) ? 1 : -1);
      }else{
        tasks.sort((a,b) => (a > b) ? -1 : 1);
      }

      return tasks.length ? tasks : [];
}
