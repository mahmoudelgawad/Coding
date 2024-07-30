import { Component, EventEmitter, Input, input, Output, output, signal } from '@angular/core';
import { Ticket } from '../ticket.model';

@Component({
  selector: 'app-ticket',
  standalone: true,
  imports: [],
  templateUrl: './ticket.component.html',
  styleUrl: './ticket.component.css'
})
export class TicketComponent {
//@Input() ticket! : Ticket;
ticket = input.required<Ticket>();
isDetailsVisible = signal(false);

//@Output() close = new EventEmitter();
close = output();

onToggleDetails(){
 //this.isDetailsVisible.set(!this.isDetailsVisible());
 // you can use 'update' instead 'set' with signal object
 this.isDetailsVisible.update( (val) => !val);
}

onTicketCompleted(){
  this.close.emit();
}

}
