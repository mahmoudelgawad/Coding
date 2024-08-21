import { inject, Injectable, signal } from "@angular/core";
import { Task, TaskStatus } from "./task.model";
import { TasksListComponent } from "./tasks-list/tasks-list.component";
import { LoggingService } from "../logging.service";

//comment if you using another way to ject
//1- appboostrab configruation providers
//2- element @component decorator providers

//will create single instance for entire app root
@Injectable({providedIn:"root"})
export class TasksService{

    private tasks = signal<Task[]>([]);
    allTasks = this.tasks.asReadonly();

    loggingService= inject(LoggingService); //inject service insed service

    addTask(taskData:{title:string, description:string}){
        let newTask:Task= {
            ...taskData,
            id:Math.random().toString(),
            status:"OPEN"
        }
        this.tasks.update((old) => [...old,newTask]);
        this.loggingService.log(`ADD TASK:${taskData.title}`);
    }

    updateTasksStatus(taskId:string,taskStatus:TaskStatus)
    {
        this.tasks.update((old) => old.map((task) => 
            (task.id === taskId) ? {...task,status:taskStatus} : task  ));
        this.loggingService.log(`UPDATE TASK STATUS:${taskStatus}`) ;    
    }

}