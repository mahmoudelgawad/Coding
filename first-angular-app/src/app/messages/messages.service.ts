import { Injectable, signal } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MessagesService {
//using signal object
// private messages = signal<string[]>([]);
// allMessages = this.messages.asReadonly();

//using rxjs observable object
private messages : string[]=[];
messages$ = new BehaviorSubject<string[]>([]);

//using signal
  // addMessage(message:string){
  //   this.messages.update((old) =>{
  //     return [...old,message]
  //   });
  // }


  //using rxjs observable
  addMessage(message:string){
    this.messages = [...this.messages,message];
    this.messages$.next(this.messages);
  }


}
