import { Routes } from "@angular/router";
import { TasksComponent } from "./tasks/tasks.component";
import { NoTaskComponent } from "./tasks/no-task/no-task.component";
import { resolvedUserNameResolver, UserTasksComponent } from "./users/user-tasks/user-tasks.component";
import { NewTaskComponent } from "./tasks/new-task/new-task.component";
import {NotFoundPageComponent} from "./not-found/not-found-page.component";
import {routes as usersRoutes} from './users/users.routes';

export const appRoutes :Routes = [
    {
        path:"", // website.com
        component:NoTaskComponent
        /*
        redirectTo:"users/u1", // just for testing if user enter domain url
        pathMatch:"full" //same result of 'prefix'
        */
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
       children:usersRoutes, // you can split nested routes in other file
       data:{
        staticMessage:'hello mahmoud' //it can auto binding as input for the component, because of 'withComponentInputBinding' in app config
       },
       resolve:{
        //resolver can be function or can be class based 
        resolvedUserName: resolvedUserNameResolver 
       }
    },
    {
        path:'**', //if url not found
        component:NotFoundPageComponent
    }
];