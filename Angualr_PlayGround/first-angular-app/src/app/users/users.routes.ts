import { Routes } from "@angular/router";
import { TasksComponent } from "../tasks/tasks.component";
import { NewTaskComponent } from "../tasks/new-task/new-task.component";

export const routes : Routes = [
    {
        path:'', // path = nothing but just equal parent path 'users/:userId'
        redirectTo:'tasks',
        pathMatch:"prefix" // put parent path 'users/:userId' prefix (first) then redirecTo value 'tasks'
    },
    {
        path:'tasks', // yourdomain.com/users/<userId>/tasks
        component: TasksComponent,
        //runGuardsAndResolvers:"always", // run resolver with all kind of URL changes
                                        //Parameters(user/userid:/tasks) (userid = u3) or Query Paramerters (?order=desc)
        resolve:{
            // resolvedUserTasks:resolvedUserTasksResolver
        }
    },
    {
        path:"tasks/new",
        component:NewTaskComponent
    }
   ];