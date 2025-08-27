const longestCommonPrefix = (strs=[""]) =>{
    if(!strs || strs.length ==0) return "";
    strs.sort();
    let first = strs[0], last = strs[strs.length - 1], result="";
    for(let i = 0; i < first.length; i++){
        if(i < last.length && first[i] === last[i])
            result += first[i];
        else
            break; 
    }
    return result;
}

console.time();
 console.log({result:longestCommonPrefix(["Flower", "Flow","Fligth"])});
 console.log({result:longestCommonPrefix(["dog", "racecar", "car" ])});
 console.log({result:longestCommonPrefix(["cir", "car"])});
 console.log({result:longestCommonPrefix(["reflower", "flow", "flight"])});
 console.timeEnd();