import { ChangeDetectionStrategy, ChangeDetectorRef, Component, DestroyRef, inject, input, OnInit } from '@angular/core';
import { MessagesService } from '../messages.service';

@Component({
  selector: 'app-messages-list',
  standalone: true,
  templateUrl: './messages-list.component.html',
  styleUrl: './messages-list.component.css',
  changeDetection:ChangeDetectionStrategy.OnPush
})
export class MessagesListComponent implements OnInit {
  // messages = input.required<string[]>();

// private to not allow access service instance from the view template
private messagesService = inject(MessagesService);
//  messages = this.messagesService.allMessages;

 //to check changes manually, when not use signal object
 cdr = inject(ChangeDetectorRef);
 destroyRef = inject(DestroyRef);
 messages: string[] = [];
 ngOnInit(): void {
   let messagesSubscribtion = this.messagesService.messages$.subscribe((result) =>{
    this.messages = result;
    //if not exist will not detect changes
    //this.cdr.markForCheck();
   });

   //for best breformance for components
   this.destroyRef.onDestroy(() =>{
    messagesSubscribtion.unsubscribe();
   });
 }

  get debugOutput() {
    console.log('[MessagesList] "debugOutput" binding re-evaluated.');
    return 'MessagesList Component Debug Output';
  }
}
