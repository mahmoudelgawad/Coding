
/**
 * @param {number[]} nums
 * @return {number}
 */
var removeDuplicates = function(nums) {
    if(!nums || nums.length ==0) return 0;
    k=0;
    for(i=1;i<nums.length;i++)
    {
       if(nums[k] != nums[i])
            nums[++k] = nums[i] 
    }
    return k+1;
};


console.time();
let testCase=[4,4,4,5,5,9,9,10,10,10,7,7];
 console.log({value:testCase, result:removeDuplicates(testCase)});
 testCase=[1,1,2];
 console.log({value:testCase, result:removeDuplicates(testCase)});
console.timeEnd();
