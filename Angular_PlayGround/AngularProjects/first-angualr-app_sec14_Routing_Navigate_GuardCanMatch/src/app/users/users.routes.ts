import { Routes } from "@angular/router";
import { resolvedUserTasksResolver, TasksComponent } from "../tasks/tasks.component";
import { canLeaveEditPage, NewTaskComponent } from "../tasks/new-task/new-task.component";

export const routes : Routes = [
    {
        path:'', // path = nothing but just equal parent path 'users/:userId'
        redirectTo:'tasks',
        pathMatch:"prefix" // put parent path 'users/:userId' prefix (first) then redirecTo value 'tasks'
    },
    {
        path:'tasks', // yourdomain.com/users/<userId>/tasks
        component: TasksComponent,
        runGuardsAndResolvers:"always", // run resolver with all kind of URL changes that contains params and query params
                                        //Parameters(user/userid:/tasks) (userid = u3) and Query Paramerters (?order=desc)
        resolve:{
            resolvedUserTasks:resolvedUserTasksResolver //use it as an input
        }
    },
    {
        path:"tasks/new",
        component:NewTaskComponent,
        //logic or process when leave the current URL
        canDeactivate:[canLeaveEditPage]
    }
   ];