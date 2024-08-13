import { Pipe, PipeTransform } from "@angular/core";
import { pipe } from "rxjs";

@Pipe({
    name:'temp',
    standalone:true
})
export class TempraturePipe implements PipeTransform{ // custome pipe
    transform(value: string | number, ...args: any[]) { //act with union types string or number
        let val;
        if(typeof value === 'string'){
            val = parseFloat(value);
        }else{
            val = value;
        }
        const tempVal = val * (9/5) + 32;
        return `${tempVal} oF`;
    }
}