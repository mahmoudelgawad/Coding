import { Injectable, signal } from "@angular/core";
import { Task } from "./task.model";
import { TasksListComponent } from "./tasks-list/tasks-list.component";

@Injectable({providedIn:"root"})
export class TaskService{

    private tasks = signal<Task[]>([]);

    allTasks = this.tasks.asReadonly();

    addTask(taskData:{title:string, description:string}){
        let newTask:Task= {
            ...taskData,
            id:Math.random().toString(),
            status:"OPEN"
        }
        this.tasks.update((old) => [...old,newTask]);
    }

}