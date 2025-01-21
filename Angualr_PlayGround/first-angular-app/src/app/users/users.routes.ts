import { ActivatedRouteSnapshot, ResolveFn, RouterStateSnapshot, Routes } from "@angular/router";
import { canLeaveEditPage, NewTaskComponent } from "../tasks/new-task/new-task.component";
import { TasksComponent } from "../tasks/tasks.component";
import { userTasksResolver } from "../tasks/task/task.component";
import { TasksService } from "../tasks/tasks.service";




export const routes : Routes = [
    {
      path:'',
      //load Lazy the 'TasksService' for nested routes or children
      providers:[TasksService],
      children:[
        {
          path:'', // path = nothing but just equal parent path 'users/:userId'
          redirectTo:'tasks',
          pathMatch:"prefix" // put parent path 'users/:userId' prefix (first) then redirecTo value 'tasks'
      },
      {
          path:'tasks', // yourdomain.com/users/<userId>/tasks
          
          //eager loading
           component: TasksComponent,
  
          //lazy loading
          //loadComponent:()=> import('../tasks/tasks.component').then((module) => module.TasksComponent),
          
          //run resolver with all kind of URL changes that contains params and query params
          //Parameters(user/userid:/tasks) (userid = u3) and Query Paramerters (?order=desc)
          runGuardsAndResolvers:"always",
          
          resolve:{
              resolvedUserTasks:userTasksResolver //use it as an input
          }
      },
      {
          path:"tasks/new",
          component:NewTaskComponent,
          //logic or process when leave the current URL
          canDeactivate:[canLeaveEditPage]
      }
      ]
    }
   ];



/*
//<< this version (1): that we use lazy loading for component 'TasksComponnet'
//<< and it's resolver function 'userTasksResolver' in 'users.routes.ts' file

// is here because error message: locked use instance before declaration
export const userTasksResolver:ResolveFn<Task[]> = (
  activatedRouteSnapShot:ActivatedRouteSnapshot,
  routerStateSnapshot:RouterStateSnapshot) => {
    const order = activatedRouteSnapShot.queryParams['order']; //xxxx?order=desc
    const tasksService = inject(TasksService);
    const tasks = tasksService.allTasks().filter(
      t => t.userId === activatedRouteSnapShot.paramMap.get('userId')); //xxx/users/userId:/tasks
    
      if(order && order === 'asc'){
        // tasks.sort((a,b) => {return (a > b) ? 1 : -1 ;});
        tasks.sort((a,b) => (a > b) ? 1 : -1 );
      }else{
        tasks.sort((a,b) => (a > b) ? -1 : 1 );
      }

      return tasks.length ? tasks : [];
}

export const routes : Routes = [
    {
        path:'', // path = nothing but just equal parent path 'users/:userId'
        redirectTo:'tasks',
        pathMatch:"prefix" // put parent path 'users/:userId' prefix (first) then redirecTo value 'tasks'
    },
    {
        path:'tasks', // yourdomain.com/users/<userId>/tasks
        
        //eager loading
        // component: TasksComponent,

        //lazy loading
        loadComponent:()=> import('../tasks/tasks.component').then((module) => module.TasksComponent),
        
        //run resolver with all kind of URL changes that contains params and query params
        //Parameters(user/userid:/tasks) (userid = u3) and Query Paramerters (?order=desc)
        runGuardsAndResolvers:"always",

        resolve:{
            resolvedUserTasks:userTasksResolver //use it as an input
        }
    },
    {
        path:"tasks/new",
        component:NewTaskComponent,
        //logic or process when leave the current URL
        canDeactivate:[canLeaveEditPage]
    }
   ];

//<< END of version (1)
*/