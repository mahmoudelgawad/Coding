//https://github.com/google/closure-compiler/wiki/Annotating-JavaScript-for-the-Closure-Compiler
//#Annotation for javascript google clouser compiler
//#apply only on variable function
/**
 * @param {string} value
 * @return {number}
 */
const longestSubstring = function(value) {
    let map = new Map();
    let maxLength=0;
    let left =0;
    for(let right = 0; right < value.length; right++){
        if(map.has(value[right]))
            left = Math.max(left,map.get(value[right]) + 1 );
        
        map.set(value[right],right);
        maxLength = Math.max(maxLength,right - left + 1);
    }
    return maxLength;
};


let testCase="pwwkew";
console.time();
console.log({value:testCase, result:longestSubstring(testCase)});
console.timeEnd();

testCase="wwwkep";
console.time();
console.log({value:testCase, result:longestSubstring(testCase)});
console.timeEnd();
