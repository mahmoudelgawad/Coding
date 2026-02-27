//https://github.com/google/closure-compiler/wiki/Annotating-JavaScript-for-the-Closure-Compiler
//#Annotation for javascript google clouser compiler
//#apply only on variable function
/**
 * @param {number[]} candies
 * @param {number} extraCandies
 * @return {boolean[]}
 */
const kidsWithCandies = function(candies, extraCandies) {
    //let max  = candies.toSorted((a,b) => b-a)[0];
    let max = Math.max(...candies);
    return candies.map(c => c+extraCandies >= max ? true : false);
};


let testCase01=[2,3,5,1,3];
let output01 = [true,true,true,false,true];
console.time();
console.log({value:[2,3,5,1,3], result:kidsWithCandies(testCase01,3)});
console.timeEnd();

