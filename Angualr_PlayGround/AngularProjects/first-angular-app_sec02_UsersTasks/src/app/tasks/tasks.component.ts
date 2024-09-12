import { Component, Input, inject } from '@angular/core';
import{TaskComponent} from "./task/task.component";
import { NewTaskComponent } from './new-task/new-task.component';
import { NewTaskData } from './task/task.model';
import { TasksService } from './tasks.service';

@Component({
  selector: 'app-tasks',
  standalone: true,
  imports: [TaskComponent,NewTaskComponent],
  templateUrl: './tasks.component.html',
  styleUrl: './tasks.component.css'
})
export class TasksComponent {
 @Input({required:true}) userId! : string; 
 @Input({required:true}) userName! : string; 

 isAddingTask =false;

 tasksService = inject(TasksService);
// constructor(private tasksService:TasksService){

// }

get selectedUserTasks(){
  return this.tasksService.getUserTasks(this.userId);
}

onTaskComplete(id:string){
 this.tasksService.removeTask(id);
}

onAddingTask(){
  this.isAddingTask = true;
}

onCancelTask(){
  this.isAddingTask = false;
}

onAddNewTaskData(taskData:NewTaskData){
 this.tasksService.addTask(taskData,this.userId)
 this.isAddingTask = false;
}
 
}
