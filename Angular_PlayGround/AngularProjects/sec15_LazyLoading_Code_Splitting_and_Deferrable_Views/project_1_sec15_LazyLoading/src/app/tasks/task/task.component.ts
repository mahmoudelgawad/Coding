import { Component, inject, input } from '@angular/core';
import { DatePipe } from '@angular/common';

import { type Task } from './task.model';
import { CardComponent } from '../../shared/card/card.component';
import { TasksService } from '../tasks.service';
import { ActivatedRoute, ActivatedRouteSnapshot, ResolveFn, Router, RouterStateSnapshot } from '@angular/router';

@Component({
  selector: 'app-task',
  standalone: true,
  templateUrl: './task.component.html',
  styleUrl: './task.component.css',
  imports: [DatePipe, CardComponent],
})
export class TaskComponent {
  task = input.required<Task>();
  private tasksService = inject(TasksService);
  private router = inject(Router);
  private activatedRoute = inject(ActivatedRoute);

  onComplete() {
    this.tasksService.removeTask(this.task().id);
    //to fix problem, resolver re load the tasks again with updated removed tasks
    this.router.navigate(['./'],{
      //to keep on current same url page 
      relativeTo:this.activatedRoute, 
      onSameUrlNavigation:'reload',
      // to keep query parameters values when navigate
      queryParamsHandling:'preserve'
    });
  }
}

export const userTasksResolver:ResolveFn<Task[]> = (
  activatedRouteSnapShot:ActivatedRouteSnapshot,
  routerStateSnapshot:RouterStateSnapshot) => {
    const order = activatedRouteSnapShot.queryParams['order']; //xxxx?order=desc
    const tasksService = inject(TasksService);
    const tasks = tasksService.allTasks().filter(
      t => t.userId === activatedRouteSnapShot.paramMap.get('userId')); //xxx/users/userId:/tasks
    
      if(order && order === 'asc'){
        // tasks.sort((a,b) => {return (a > b) ? 1 : -1 ;});
        tasks.sort((a,b) => (a > b) ? 1 : -1 );
      }else{
        tasks.sort((a,b) => (a > b) ? -1 : 1 );
      }

      return tasks.length ? tasks : [];
}