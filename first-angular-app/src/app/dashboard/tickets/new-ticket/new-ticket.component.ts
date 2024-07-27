import { Component, ElementRef, EventEmitter, Output, viewChild, ViewChild,  } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ControlComponent } from "../../../shared/control/control.component";
import { ButtonComponent } from '../../../shared/button/button.component';

@Component({
  selector: 'app-new-ticket',
  standalone: true,
  imports: [ControlComponent, ButtonComponent, FormsModule],
  templateUrl: './new-ticket.component.html',
  styleUrl: './new-ticket.component.css'
})
export class NewTicketComponent {
  //@ViewChild('form')
  //form? : ElementRef<HTMLFormElement>;
 private form = viewChild.required<ElementRef<HTMLFormElement>>('form');

 @Output() addNewTicket = new EventEmitter<{title: string, request: string}>();

  onSubmit(title: string, request: string){
    this.addNewTicket.emit({title: title, request: request});
    this.form().nativeElement.reset();
  }

}
