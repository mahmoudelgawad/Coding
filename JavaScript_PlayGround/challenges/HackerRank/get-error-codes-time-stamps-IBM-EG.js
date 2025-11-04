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
 
 //const errors = errorCodes.slice(startTI,endTI).
 //to be continue

}

//#how to use Array.reduce 
//https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/reduce
const test = function(){
 const words = ['E1','E2','E3','E2','E2','E1'];
 const wordsCount = words.reduce((accu,currVal) =>{
    accu[currVal] = (accu[currVal] || 0) + 1;
    return accu  
    },{});
 const result = Object.keys(wordsCount).filter(k => wordsCount[k] >= 2);
 console.log({result:result})
}

test();