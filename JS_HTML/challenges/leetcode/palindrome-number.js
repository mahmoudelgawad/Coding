
const isPalindromeNumber = (x=0) =>{
    let reverse = 0, copy = x;
    while(copy > 0){
        reverse = reverse * 10 + copy % 10;
        copy = Math.floor(copy/10);
        //console.log({r:reverse,c:copy});
    }
    return reverse === x;
}

console.log({x:242,result:isPalindromeNumber(242)});