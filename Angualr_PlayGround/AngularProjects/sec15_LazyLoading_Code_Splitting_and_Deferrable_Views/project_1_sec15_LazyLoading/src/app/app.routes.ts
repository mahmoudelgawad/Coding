import { CanMatchFn, RedirectCommand, Router, Routes } from "@angular/router";
import { TasksComponent } from "./tasks/tasks.component";
import { NoTaskComponent } from "./tasks/no-task/no-task.component";
import { resolvedUserNameResolver, titleResolver, UserTasksComponent } from "./users/user-tasks/user-tasks.component";
import { NewTaskComponent } from "./tasks/new-task/new-task.component";
import {NotFoundPageComponent} from "./not-found/not-found-page.component";
//import {routes as usersRoutes} from './users/users.routes';
import { inject } from "@angular/core";

const dummyCanMatch:CanMatchFn = (route, URLsegments) =>{
   const router = inject(Router);
   const canGetAccess = Math.random(); //return number between 0 and 1
//    if(canGetAccess < 0.5)
    if(true)//to authorized all the time for testing
     return true;
   // go to www.yourdomain.com/unautorized"    
   return new RedirectCommand(router.parseUrl('/unautorized'));
}

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

       // you can split nested routes in other file
       //children:usersRoutes,

       //will lazy loading for users children
       loadChildren:() => import('../app/users/users.routes').then(module => module.routes),
       
       data:{ // contain both params values in path URL and in following object here
        staticMessage:'hello mahmoud' //it can auto binding as input for the component, because of 'withComponentInputBinding' in app config
       },
       resolve:{
        //auto binding inputs with values from URL
        //Angualr by default re-excute resolver if URL parameters changes, and not query param
        //that is why use 'runGuardsAndResolvers'
        //resolver can be function or can be class based 
        resolvedUserName: resolvedUserNameResolver 
       },
       title:titleResolver,
       canMatch:[dummyCanMatch], // to authorize can access the url route or not, as Guard
       canActivate:undefined,
       canDeactivate:undefined
    },
    {
        path:'**', //if url not found
        component:NotFoundPageComponent
    }
];