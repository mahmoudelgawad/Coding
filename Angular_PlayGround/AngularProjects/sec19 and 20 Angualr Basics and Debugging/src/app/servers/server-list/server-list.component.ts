import { Component } from '@angular/core';

@Component({
  selector: 'app-server-list',
  templateUrl: './server-list.component.html',
  styleUrl: './server-list.component.css'
})
export class ServerListComponent {

  servers:string[] = ["server1","server2","server3","server4","server5"];

  onRemoveServerItem(index:number){
    this.servers.splice(index,1);
    console.log(`removed server ${index}`);
  }
}
