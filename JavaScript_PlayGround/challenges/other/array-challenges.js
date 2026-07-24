/**
 * 
 * @param {number[]} arr
 * @return {number[]}
 */
const getDuplicateNumbers_Set = function (arr) {
    //need to change not initialize the Set

    // let seenNumbers = new Set(arr);
    // let douplicates = [];
    // for (let n of arr) {
    //     if (seenNumbers.has(n))
    //         douplicates.push(n);
    // }

    // console.log(douplicates.join(','));
};

const compareTwoArrays = ()=>{
    let arr1=[1,2,3];
    let arr2 =[1,2,3];
    let isEqual = JSON.stringify(arr1) === JSON.stringify(arr2);
    console.log(`arr1 === arr2  ${isEqual}`);
};

getDuplicateNumbers_Set([2,6,4,9,45,7,8,12,9,6,45]);