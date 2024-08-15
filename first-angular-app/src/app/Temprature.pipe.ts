import { Pipe, PipeTransform } from "@angular/core";
import { pipe } from "rxjs";

@Pipe({
    name:'temp',
    standalone:true
})
export class TempraturePipe implements PipeTransform{ // custom pipe
    transform(value: string | number| null, inputType:'c'|'f', outputType:'f'|'c') { //act with union types string or number
        if(!value){ // check the act value is null, return as it is
            return value;
        }

        let val;
        if(typeof value === 'string'){
            val = parseFloat(value);
        }else{
            val = value;
        }

        if(inputType === 'c' && outputType === 'f'){
           val= val * (9/5) + 32;
        }else if(inputType === 'f' && outputType === 'c'){
             val= val * (5/9) - 32;
        }

       let symbol: 'oC'|'oF';

        if(!outputType){
            symbol = (inputType === 'c') ? 'oC' : 'oF';
        }else{
            symbol = (outputType === 'c') ? 'oC' : 'oF';
        }
      
        return `${val.toFixed(2)} ${symbol}`;
    }
}