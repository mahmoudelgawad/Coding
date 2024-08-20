import { bootstrapApplication } from '@angular/platform-browser';

import { AppComponent } from './app/app.component';
import { TasksService } from './app/tasks/tasks.service';

//another way to inject the services instead use @Injectable decorator
//but not recommended , because it will add the additinal info from the first code, when start budle
//like added in the begining even if not used inside the app

// bootstrapApplication(AppComponent,{
//     providers:[TasksService]
// }).catch((err) => console.error(err));

 bootstrapApplication(AppComponent).catch((err) => console.error(err));
