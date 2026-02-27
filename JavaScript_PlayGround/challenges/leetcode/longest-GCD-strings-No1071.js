//https://github.com/google/closure-compiler/wiki/Annotating-JavaScript-for-the-Closure-Compiler
//#Annotation for javascript google clouser compiler
//#apply only on variable function
/**
 * @param {string} str1
 * @param {string} str2
 * @return {string}
 */
const longestGCDStrings = function(str1,str2) {
    if(str1+str2 !== str2+str1) return "";
    let n = getGCD(str1.length, str2.length);
    return str1.substring(0,n);
};
const getGCD = function(n1,n2){
    while(n1 !== 0 && n2 !== 0){
        if(n1 > n2)
            n1%=n2;
        else
            n2%=n1;
    }
    //# bitwise logical OR operator (non-short circuting)
    return n1 | n2;
};


let str1 = "TAUXXTAUXXTAUXXTAUXXTAUXX";
let str2 = "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX";
let output = "TAUXX";
console.time();
console.log({value:testCase, result:longestGCDStrings(str1,str2), isPass : resut === output});
console.timeEnd();

