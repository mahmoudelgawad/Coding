import {Component} from '@angular/core';

@Component({
    selector:'app-warning-alert',
    template:`<p>This is alert, you are in danger</p>`,
    styles:[`
        p{
            padding:20px;
            background-color:lightcoral;
            border:1px solid red;
        }
        `]
})
export class WarningAlertComponent{

}