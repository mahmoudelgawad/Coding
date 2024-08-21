import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LoggingService {

  log(message:string){
    let timeStamp = new Date().toLocaleTimeString();
    console.log(`LOG:${message}`);
    //or you can log to send the backend

  }
}
