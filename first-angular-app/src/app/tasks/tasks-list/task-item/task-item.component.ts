import { Component, computed,  inject, input } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { Task, TASK_STATUS_OPTIONS, TaskStatus, taskStatusOptionsProvider } from '../../task.model';
import { TasksService } from '../../tasks.service';

@Component({
  selector: 'app-task-item',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './task-item.component.html',
  styleUrl: './task-item.component.css',
  // Provider object in task model
  providers:[taskStatusOptionsProvider]
})
export class TaskItemComponent {

  taskService = inject(TasksService);
  taskStatusOptions = inject(TASK_STATUS_OPTIONS);

  task = input.required<Task>();
  taskStatus = computed(() => {
    switch (this.task().status) {
      case 'OPEN':
        return 'Open';
      case 'IN_PROGRESS':
        return 'Working on it';
      case 'DONE':
        return 'Completed';
      default:
        return 'Open';
    }
  });

  onChangeTaskStatus(taskId: string, status: string) {
    console.log(taskId,status);
    let newStatus: TaskStatus = 'OPEN';

    switch (status) {
      case 'open':
        newStatus = 'OPEN'; // assign same value of TaskStatus union types
        break;
      case 'in_progress':
        newStatus = 'IN_PROGRESS';
        break;
      case 'done':
        newStatus = 'DONE';
        break;
      default:
        break;
    }
    console.log(newStatus);
    this.taskService.updateTasksStatus(taskId,newStatus);
  }


}
