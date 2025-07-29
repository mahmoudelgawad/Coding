 const romanToInt = (s="")=>{
    let num = 0;
    for(let i =0; i< s.length ; i++){
        let currNum = getIntFromRoman(s[i]);
        let prevNum = i == 0 ? 0 : getIntFromRoman(s[i-1]);
        num = currNum <= prevNum ? currNum + num : (currNum-prevNum) + (num - prevNum)  
    }
    return num;
 }
 const getIntFromRoman = (ch='')=>{
    switch(ch){
        case 'I': return 1;
        case 'V': return 5; 
        case 'X': return 10;
        case 'L': return 50;
        case 'C': return 100;
        case 'D': return 500;
        case 'M': return 1000;
        default: return 0;
    }
 }

  const romanToInt_using_JSON = (s="")=>{
    const getIntFromRoman = {
        I: 1,
        V: 5, 
        X: 10,
        L: 50,
        C: 100,
        D: 500,
        M: 1000};
    let num = 0;
    for(let i =0; i< s.length ; i++){
        let currNum = getIntFromRoman[s[i]];
        let prevNum = i == 0 ? 0 : getIntFromRoman[s[i-1]];
        num = currNum <= prevNum ? currNum + num : (currNum-prevNum) + (num - prevNum)  
    }
    return num;
 }
  
 console.time();
 console.log({x:"III",result:romanToInt("III")});
 console.log({x:"LVIII",result:romanToInt("LVIII")});
 console.log({x:"MCMXCIV",result:romanToInt("MCMXCIV")});
 console.timeEnd();