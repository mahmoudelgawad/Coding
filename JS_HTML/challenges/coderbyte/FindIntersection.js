function Findintersection(strArr){
  
  //https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/filter 
  //[].filter ,take predicate arrow function and return result as Array[]

  //https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/find
  //[].find(e e=> e==='6') return first satisfied element
  //[].includes('6') return boolean 

   //#equivelant string.join()
    //['sdsdsd'].join(',');
  if(strArr.length === 0){
    return "false";
  }

  let intercepts = strArr[0].split(',')
                             .map(e => e.replaceAll(" ",""))
       .filter(s => strArr[1].split(',')
                             .map(e => e.replaceAll(" ",""))
                             .find(s2 => s2 === s));
  //remove duplicate values, another way with filter((element,index,array)=> array.indexOf(element) === index)
  intercepts = [... new Set(intercepts)];
  // return intercepts;
  return intercepts.length > 0 ? intercepts.join(',') : 'false';  
}

console.log(
Findintersection(["1,15,15, 6, 5 9,14,70, 87", "1,6,3,5,87, 15 , 7, 7 0" ])
);

console.log(Findintersection(["",""]));
console.log(Findintersection([]));
