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
        path:"tasks", //website.com/tasks
        component:TasksComponent
        */

        /*
        path:'users/:userId/:taskId',
        component: UserTasksComponent
        */

       path:'users/:userId', // yourdomain.com/users/15
       component: UserTasksComponent,
       children:[
        {
            path:'tasks', // yourdomain.com/users/<userId>/tasks
            component: TasksComponent,
        }
       ]
    }];