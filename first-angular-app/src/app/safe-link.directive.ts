import { Directive } from "@angular/core";

@Directive({
    selector:'a[appSafeLink]',
    standalone:true,
    host:{
        '(click)' :'onConfirmLeavePage($event)'
    }
})
export class SafeLinkDirective{
    constructor(){
        console.log("from SafeLinkDirective");
    }

    onConfirmLeavePage(event:MouseEvent){
        const wantLeave = window.confirm("Do you want to Leave ?");
        if(wantLeave){
            return;
        }
        event.preventDefault();
    }
}