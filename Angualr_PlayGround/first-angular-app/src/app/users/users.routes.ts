import { Routes } from "@angular/router";
import { TasksComponent } from "../tasks/tasks.component";
import { NewTaskComponent } from "../tasks/new-task/new-task.component";

export const routes : Routes = [
    {
        path:'', // path = nothing but just equal parent path 'users/:userId'
        redirectTo:'tasks',
        pathMatch:"prefix" // put parent path 'users/:userId' prefix redirecTo value 'tasks'
    },
    {
        path:'tasks', // yourdomain.com/users/<userId>/tasks
        component: TasksComponent,
    },
    {
        path:"tasks/new",
        component:NewTaskComponent
    }
   ];