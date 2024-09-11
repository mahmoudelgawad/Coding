import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'sort',
  standalone: true,
  pure:false // detect each change on historyTemprature array and resorted
})
export class SortPipe implements PipeTransform {

  transform(value: string[] | number[],sortType: 'asc' | 'desc' = 'asc') {
    let sortedValue = [...value]; // BECAUSE sort with change the original array structure , and may affect on the other component object
    
      return sortedValue.sort((a,b) => {
        if(sortType === 'asc'){
          return a > b ? 1 : -1;
        }else{
          return a > b ? -1 : 1; // for descending order
        }
      });

    return sortedValue;
  }

}
