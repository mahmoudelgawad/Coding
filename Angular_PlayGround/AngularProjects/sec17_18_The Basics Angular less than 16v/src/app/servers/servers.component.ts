import { Component } from '@angular/core';

@Component({
  //  selector:'.app-servers',
  // selector:'[app-servers]',
  selector:'app-servers',
  templateUrl: './servers.component.html',
/*  template:`
      <h1>Servers List</h1>
      <app-server></app-server>
      <app-server></app-server>
  `,*/
  styleUrl: './servers.component.css',
})
export class ServersComponent {
  isEnabledServer = false;
  createServerStatus = "There no server created !";
  serverName="";
  isServerCreated = false;
  servers = ["Server1", "Server2"];

  constructor(){
    setTimeout(() =>{
      this.isEnabledServer = true;
    },2000);
  }

  ngOnInit(){}
  
  onCreateServer(){
    this.isServerCreated = true;
    this.servers.push(this.serverName);
    this.createServerStatus = `New server created @OK : ${this.serverName}`
  }

  onUpdateServerName(event:any){
    // console.log(event);
    // this.serverName = event.target.value;
    this.serverName = (<HTMLInputElement>(event.target)).value;
  }

}
