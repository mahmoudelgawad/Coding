import { Component, inject, input, signal } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { TasksService } from '../tasks.service';
import { CanDeactivateFn, Router,RouterLink} from '@angular/router';

@Component({
  selector: 'app-new-task',
  standalone: true,
  imports: [FormsModule, RouterLink], //most import usage for html template
  templateUrl: './new-task.component.html',
  styleUrl: './new-task.component.css',
})
export class NewTaskComponent {
  userId = input.required<string>();
  enteredTitle = signal('');
  enteredSummary = signal('');
  enteredDate = signal('');
  private tasksService = inject(TasksService);
  private router = inject(Router);
  submitted = false; //it can be Signal object instead, but here will not add into template or no multible dependencies

  onSubmit() {
    this.tasksService.addTask(
      {
        title: this.enteredTitle(),
        summary: this.enteredSummary(),
        date: this.enteredDate(),
      },
      this.userId()
    );
    this.submitted = true;
    this.router.navigate(['users/',this.userId(),'tasks'],{
                          replaceUrl:true, // to replace current url, for full redirect
                        });
  }
}

export const canLeaveEditPage:CanDeactivateFn<NewTaskComponent> = (component) =>{
  if(component.submitted){
    return true;
  }

  //asking when the form full filled with data
  if(component.enteredTitle() || component.enteredDate() || component.enteredSummary())
    return window.confirm("Do you really want to leave? You Will lose the entered data");
  
  return true;

};