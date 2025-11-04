/**
 * @param {number[]} nums
 * @param {number} val
 * @return {number}
 */
var removeElement = function(nums, val) {
    if(nums.length === 0) return 0;
    //#Array.map() like c# '[].Select()' will change/transform each element
    //let numsFiltered = nums.map(e => e !== val);
    let numsFiltered = nums.filter(e => e !== val);
    nums.splice(0,numsFiltered.length,...numsFiltered);
    return nums.length  - numsFiltered.length;
};

var removeElement_Final = function(nums, val) {
    if(nums.length === 0) return 0;
    let index= 0;
    for(let i = 0; i < nums.length; i++){
       if(nums[i]!= val){
         nums[index] = nums[i];
         ++index;
       } 
    }
    return index;    
};


let testCase= [5,9,5,12,3,5];
let val= 5;
console.time();
 console.log({value:testCase, result:removeElement(testCase,val)});
console.timeEnd();

testCase = [5,9,5,12,3,5];
console.time();
console.log({value:testCase, result:removeElement_Final(testCase,val)});
console.timeEnd();
 //testCase="()";

