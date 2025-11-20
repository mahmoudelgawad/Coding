/*
 * Complete the 'diagonalDifference' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts 2D_INTEGER_ARRAY arr as parameter.
 */

/**
 * 
 * @param {[][]} arr
 * @return {number} 
 */
const  diagonalDifference = function(arr) {
    let totalL=0;
    let totalR = 0;
    let r =0;
    for(let m = 0 ; m < arr.length; m++ ){
        r = arr[m].length - 1 - m;
        totalL += arr[m][m];
        totalR += arr[m][r]; 
    }
    let diff =  totalL - totalR;
    return diff < 0 ? diff * -1 : diff;

}

let testCase=[
[1,2,3],
[4,5,6],
[9,8,9]
];
console.time();
console.log({value:testCase, result:diagonalDifference(testCase)});
console.timeEnd();
