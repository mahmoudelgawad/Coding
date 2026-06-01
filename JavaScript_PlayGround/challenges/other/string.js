/**
 * 
  @param {string} str 
 */
const stringReverseWays = function(str){
    let result;
   //#1. Built-in Methods (Recommended), split return array
   result = str.split('').reverse().join('');
   console.log(result);

    //#2 spread operator with string
   result = [...str].reverse().join('');
    console.log(result);

   //#3 loop
   let strReversed='';
   for(i = str.length-1 ; i >= 0 ; i--)
        strReversed += str[i];
   result = strReversed;
    console.log(result);
}

stringReverseWays('Mahmoud Ahmed');