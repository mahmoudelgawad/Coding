/**
 * @param {string} encode
 * @return {string}
 */

const decode = function(encode){
 if(encode.length === 0) return "";
 const arrASCII = encode.split('').reverse();
 let str = "";
 let result="";
 for(let d of arrASCII)
   {
     str+=a;
      if(str.length >= 2)
       {
         //#'d'.charCodeAt(0)
         //#accept multi params String.fromCharCode(14,15,115,44,169)
         let ch = String.fromCharCode(str);
         result+=ch;
         str=''; 
       }
       else if(str.length > 2) str='';
   }
   return result;
}




let result = getErrorCodesTimestamps(
   2,
   10,
   [100, 101, 102, 105, 110 ],
   ["E1","E2","E1","E1","E2"]);
console.log(result);//E2,E1


result = getErrorCodesTimestamps(
   3,
   5,
   [1, 2, 4, 5, 6, 7, 10 ],
   ["E1", "E2", "E1", "E1", "E2", "E2", "E2"]);
console.log(result);//E2


result = getErrorCodesTimestamps(
   2,
   4,
   [1, 2, 4, 5, 6 ],
   ["E1", "E2", "E1", "E1", "E2"]);
console.log(result);//E1

result = getErrorCodesTimestamps(
   2,
   4,
   [1, 2, 4, 5, 6 ],
   ["E1", "E2", "E3", "E4", "E5"]);
console.log(result);//[] no errors
