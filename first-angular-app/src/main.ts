import { bootstrapApplication } from '@angular/platform-browser';

import { AppComponent } from './app/app.component';
import { TasksService } from './app/tasks/tasks.service';
import { LoggingService } from './app/logging.service';
import { InjectionToken } from '@angular/core';

//1-another way to inject the services instead use @Injectable decorator
//but not recommended , because it will add that services info or files from the first code, when start bundle
//like added in the begining even if not used inside the app

// bootstrapApplication(AppComponent,{
//     providers:[TasksService]
// }).catch((err) => console.error(err));


//2- another way use custom DI token
/*export const taskServiceToken = new InjectionToken<TasksService>("TasksService_TokenID");
bootstrapApplication(AppComponent,
  {providers:[{provide:taskServiceToken,useClass:TasksService}]
}).catch((err) => console.error(err));
*/

/*
-use from component with inject method:
taskService = inject(taskServiceToken);
this.taskService

-use component constructor
constructor(@inject(taskServiceToken) private taskService:TaskService){}
*/

 bootstrapApplication(AppComponent).catch((err) => console.error(err));
