import { Component } from "@angular/core";

/*
#DOCUMENTATION#
https://loading.io/css/
*/

@Component({
    selector:'app-loading-spinner',
    template:'<div class="lds-ripple"><div></div><div></div></div>',
    styleUrl:'./loading-spinner.component.css'
})
export class LoadingSpinnerComponent{

}