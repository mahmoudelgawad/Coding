/**
 * @param {string} s
 * @return {boolean}
 */
var isValid = function(s="") {
    let lastClose = [];
    //#foreach work on array,map, sets only, not string variable directly{
    //#any way will not using becasue can not break or 'return false' from function boundry
    //Array.from(s).forEach(ch =>{});
    for(let i = 0 ; i < s.length; i++){
        if(s[i] === '(') lastClose.push(')');
        else if(s[i] === '{') lastClose.push('}'); 
        else if(s[i] === '[') lastClose.push(']');
        else if(s[i] !== lastClose.pop()) return false;
    }
    return lastClose.length === 0;
};

console.time();
let testCase="({})";
 console.log({value:testCase, result:isValid(testCase)});
 testCase="()";
 console.log({value:testCase, result:isValid(testCase)});
 testCase="()[]{}";
 console.log({value:testCase, result:isValid(testCase)});
  testCase="(]";
 console.log({value:testCase, result:isValid(testCase)});
 testCase="([)]";
 console.log({value:testCase, result:isValid(testCase)});
console.timeEnd();