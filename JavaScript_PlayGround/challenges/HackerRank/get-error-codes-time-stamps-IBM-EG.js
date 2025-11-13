/**
 * @param {number} k
 * @param {number} t
 * @param {number[]} timestamps
 * @param {string[]} errorCodes
 * @return {string[]}
 */
       //k = number of occurrences
       //t = size of the times window in seconds (last seconds)
const getErrorCodesTimestamps = function(k, t, timestamps,errorCodes){
 let endTI = timestamps.length-1;
 let startTV = timestamps[endTI] - (t-1);
 let startTI = timestamps.findIndex(t => t >= startTV);
 
 const errPeriod = errorCodes.slice(startTI,endTI+1);
 const acc = {};
 for(let err of errPeriod) acc[err] = (acc[err] || 0) +1 ;
 const errors = Object.keys(acc).filter(err => acc[err] >= k);
return errors;
}

//#how to use Array.reduce 
//https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/reduce
const test = function(){
 const words = ['E1','E2','E3','E2','E2','E1'];
 const wordsCount = words.reduce((accu,currVal) =>{
    accu[currVal] = (accu[currVal] || 0) + 1;
    return accu;  
    },{});
 const result = Object.keys(wordsCount).filter(k => wordsCount[k] >= 2);
 console.log({result:result});
}

//#how to use 'new Map()' instance
const test2 = function(){
   const words = ['E1','E2','E3','E2','E2','E1'];
   const acc = new Map();
   for(let w of words) acc.set(w, (acc.get(w) || 0) +1);
   const result = [...acc.entries()].filter(([_,count]) => count >=2 )
                                    .map(([er]) => er);
   console.log(result);
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
