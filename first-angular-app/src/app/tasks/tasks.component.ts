import { Component, Input } from '@angular/core';
import{TaskComponent} from "./task/task.component";
import { NewTaskComponent } from './new-task/new-task.component';
import { NewTaskData } from './task/task.model';

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

constructor(){
  
}

get selectedUserTasks(){
  
}

onTaskComplete(id:string){
 
}

onAddingTask(){
  this.isAddingTask = true;
}

onCancelTask(){
  this.isAddingTask = false;
}

onAddNewTaskData(taskData:NewTaskData){

 this.isAddingTask = false;
}
 
}
