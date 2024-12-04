import { Routes } from "@angular/router";
import { TasksComponent } from "./tasks/tasks.component";
import { NoTaskComponent } from "./tasks/no-task/no-task.component";
import { UserTasksComponent } from "./users/user-tasks/user-tasks.component";

export const appRoutes :Routes = [
    {
        path:"", // website.com
        component:NoTaskComponent
    },
    {
        /*
        path:"tasks", //website.com/taks
        component:TasksComponent
        */
       path:'users/:userId/:taskId',
       component: UserTasksComponent
    }];