import { Component, ElementRef, viewChild } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { TaskService } from '../tasks.service';

@Component({
  selector: 'app-new-task',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './new-task.component.html',
  styleUrl: './new-task.component.css',
})
export class NewTaskComponent {

  service:TaskService;
  private formEl = viewChild<ElementRef<HTMLFormElement>>('form');

  constructor(){
    this.service = new TaskService();
  }

  onAddTask(title: string, description: string) {
    this.service.addTask({title:title,description:description});
    this.formEl()?.nativeElement.reset();
  }
}
