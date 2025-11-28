import { Component, EventEmitter, Output, ViewChild, ElementRef } from '@angular/core';

@Component({
  selector: 'app-cockpit',
  templateUrl: './cockpit.component.html',
  styleUrl: './cockpit.component.css'
})
export class CockpitComponent {
  @Output() serverCreated = new EventEmitter<{serverName: string, serverContent: string}>();

  //#put aliase name for '@Output' instance
  //@Output() bluePrintCreated = new EventEmitter<{serverName: string, serverContent: string}>();
  @Output('bpCreated') bluePrintCreated = new EventEmitter<{serverName: string, serverContent: string}>();
  
  //# two way binding variables
  newServerNameVar = '';
  newServerContentVar = '';

  @ViewChild('newServerContent') newServerContent:ElementRef;

    onAddServer(serverNameInput:HTMLInputElement) {
      this.serverCreated.emit({
        // serverName : this.newServerName,
        serverName : serverNameInput.value,
        serverContent : this.newServerContent.nativeElement.value
      });
  }

  onAddBlueprint(serverNameInput:HTMLInputElement) {
    this.bluePrintCreated.emit({
      // serverName : this.newServerName,
      serverName : serverNameInput.value,
      serverContent : this.newServerContent.nativeElement.value
    });

    //#!! not recomended change value of ElementRef directly 
    // this.newServerContent.nativeElement.value = 'new value';
  }

}
