import { Directive, ElementRef, inject, input } from "@angular/core";

@Directive({
    selector:'a[appSafeLink]',
    standalone:true,
    host:{
        '(click)' :'onConfirmLeavePage($event)'
    }
})
export class SafeLinkDirective{ // custome attribute  directive
    
    //input take same aliase name of current directive
    queryParam = input("ebcell.com",{alias:'appSafeLink'});
    hostAnchorElementRef = inject<ElementRef<HTMLAnchorElement>>(ElementRef);
    constructor(){
        console.log("from SafeLinkDirective");
    }

    onConfirmLeavePage(event:MouseEvent){
        const wantLeave = window.confirm("Do you want to Leave ?");
        if(wantLeave){
            //before leave , edit current host anchor href address with my website programmatically
            this.hostAnchorElementRef.nativeElement.href = 
                this.hostAnchorElementRef.nativeElement.href + "?from="+ this.queryParam();

            //old way
            /*let anchor = (event.target as HTMLAnchorElement);
            anchor.href = anchor.href + "?from="+ this.queryParam();
            */
            return;
        }
        event.preventDefault();
    }
}