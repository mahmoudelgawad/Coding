//https://github.com/google/closure-compiler/wiki/Annotating-JavaScript-for-the-Closure-Compiler
//#Annotation for javascript google clouser compiler
//#apply only on variable function
/**
 * @param {number[]} nums
 * @return {void}
 */
const moveZeros = function(nums) {
    //# using waterfall algorithm
    let zerosCounter = 0;
    for(let i=0; i<nums.length; i++){
        if(nums[i] == 0)
            ++zerosCounter;
        else if (zerosCounter > 0){
          let temp = nums[i];
          nums[Math.abs(zerosCounter - i)] = temp;
          nums[i] = 0;  
        }
    }
    console.log(nums.join());
};

let testCase=[1,0,3,0,2,1];
moveZeros(testCase);
