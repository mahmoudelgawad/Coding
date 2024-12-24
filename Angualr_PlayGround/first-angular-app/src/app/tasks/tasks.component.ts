import { Component, computed, DestroyRef, inject, input, OnInit, signal } from '@angular/core';

import { TaskComponent } from './task/task.component';
import { Task } from './task/task.model';
import { TasksService } from './tasks.service';
import { ActivatedRoute, RouterLink } from '@angular/router';

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
