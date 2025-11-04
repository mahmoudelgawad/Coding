/**
 * @param {string} haystack
 * @param {string} needle
 * @return {number}
 */
var findFirstIndexOccurrence = function(haystack="", needle="") {
    return haystack.indexOf(needle);
};

var findFirstIndexOccurrence_Final = function(haystack="", needle="") {
    for(let i=0; i <= haystack.length - needle.length; i++){
        if(haystack.substring(i,i+needle.length) === needle) return i;
    }
    return -1;
};


let haystack="AllahAkbar";
let needle="hAk";
console.time();
console.log({value:haystack, result:findFirstIndexOccurrence(haystack, needle)});
console.timeEnd();

console.time();
console.log({value:haystack, result:findFirstIndexOccurrence_Final(haystack, needle)});
console.timeEnd();
/*
testCase="()";
*/