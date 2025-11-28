//https://www.hackerrank.com/challenges/staircase/problem?isFullScreen=true
/**
 * 
 * @param {number} n
 * @return {string} 
 */

/*
 * Complete the 'staircase' function below.
 *
 * The function accepts INTEGER n as parameter.
 */

function staircase(n) {
    let spaceCount = 0;
    let charCount = 0;
   for(let i = 0 ; i < n ; i++){
    spaceCount = n - i - 1;
    charCount = i+1;
    console.log(' '.repeat(spaceCount) + '#'.repeat(charCount));
   }
}

//#testing your code

let testCase= 6;
console.time();
staircase(testCase);
console.timeEnd();
testCase="()";
