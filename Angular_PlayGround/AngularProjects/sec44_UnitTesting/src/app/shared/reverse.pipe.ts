import { Pipe } from "@angular/core";

//#custome pipe to reverse string
@Pipe({
  name: 'reverse'
})
export class ReversePipe {
  
  //#implement transform function
  transform(value: string) {
    return value.split("").reverse().join("");
  }
}
