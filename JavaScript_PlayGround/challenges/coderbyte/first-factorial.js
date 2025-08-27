const firstFactorial = (num=0)=>{
    if(num === 0){
        return 0;
    }
    return num === 1 ? 1 : num * firstFactorial(num-1);
}

console.log({input:4,result: firstFactorial(4)});
console.log({input:8,result: firstFactorial(8)});