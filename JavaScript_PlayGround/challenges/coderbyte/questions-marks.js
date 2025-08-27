const questionsMarks =function(str){
    let qCounter = 0;
    let startDigit = 'n';
    let endDigit = 'n';
    let result = 'false';
    for(let i = 0; i < str.length; i++){
        let ch = str[i];
        if(ch === '?' && startDigit !== 'n'){
            ++qCounter;
        }
        if(parseInt(ch)){ // false = NaN
            if(startDigit === 'n'){
                startDigit = ch;
            }
            else if(endDigit === 'n'){
                endDigit = ch;
                if((parseInt(startDigit) + parseInt(endDigit)) === 10 && qCounter === 3){
                    result = 'true';
                    startDigit = endDigit;
                    endDigit = 'n'
                    qCounter = 0;
                }
                else if((parseInt(startDigit) + parseInt(endDigit)) === 10 && qCounter !== 3){
                    return "false";
                }
            }           
        }      
    }
    return result;
}

console.log(questionsMarks('mahmoud3???7sdmks2fff???gg5'));
console.log(questionsMarks('mahmouda???bsdmks2fff???gg5'));
console.log(questionsMarks('mahmouda??5?bsdmksvfff??5?'));
console.log(questionsMarks('9???1???9??1???9'));
console.log(questionsMarks('5??aaaaaaaaaaaaaaaaaaa?5?5'));


