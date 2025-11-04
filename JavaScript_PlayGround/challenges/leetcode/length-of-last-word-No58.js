//https://github.com/google/closure-compiler/wiki/Annotating-JavaScript-for-the-Closure-Compiler
//#Annotation for javascript google clouser compiler

/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLastWord = function(s) {
  if(s.length == 0) return 0;
  s= s.trim();
  let arr = s.split(" ");
  return arr[arr.length-1].length;  
};


let testCase="  stop fire  ";
console.time();
console.log({value:testCase, result:lengthOfLastWord(testCase)});
console.timeEnd();
