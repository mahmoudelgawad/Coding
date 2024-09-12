import { ChangeDetectionStrategy, Component, signal } from '@angular/core';

import { MessagesListComponent } from './messages-list/messages-list.component';
import { NewMessageComponent } from './new-message/new-message.component';
import { BehaviorSubject } from 'rxjs';

@Component({
  selector: 'app-messages',
  standalone: true,
  templateUrl: './messages.component.html',
  styleUrl: './messages.component.css',
  imports: [MessagesListComponent, NewMessageComponent],
  // its less aware of events listeners outside compoment
  // or less evaluate changes on current compoennt, with unnessary detect changes comming from outside
  // but not restrict local events, it send changes to other components
  // if input changes , or locla manually changes, send event detect changes for the root components
  // enhance performance effecincy , if your project big
  // and your component have no inputs
  changeDetection:ChangeDetectionStrategy.OnPush
})
export class MessagesComponent {
   messages = signal<string[]>([]);

  get debugOutput() {
    console.log('[Messages] "debugOutput" binding re-evaluated.');
    return 'Messages Component Debug Output';
  }

  onAddMessage(message: string) {
    this.messages.update((oldMessages) => [...oldMessages, message]);
  }
}
