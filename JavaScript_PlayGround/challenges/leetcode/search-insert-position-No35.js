/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var searchInsert = function(nums, target) {
    let mid = Math.floor(nums.length / 2);
    mid = target < mid ? 0 : mid;
    for(let i = mid; i < nums.length; i++){
        if(nums[i] >= target) return i;
    }
    return nums.length;
};


let testCase=[1,2,3,4,5,6]; let target = 4; 
console.time();
console.log({value:testCase, result:searchInsert(testCase,target)});
console.timeEnd();
//testCase="()";
