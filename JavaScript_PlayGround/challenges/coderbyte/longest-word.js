//https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Regular_expressions

var longestWord = (str="") => {
  const regExp = /[^\w\s]/g;
  //# string "replace(regEx,'')" normally match first one  without global regExp, need 'g' flag to match all.
  //# string "replaceAll(regEx,'')" normally match all ,but must follow 'g' as global regExp
  
  //let res = str.replace(regExp,""); 
  let resArr = str.replaceAll(regExp,"")
              .split(' ')
              .sort((a,b) =>{return b.length - a.length});

  // TO BE CONTINUE SPLIT WORDS AND ORDER DESC BY LENGTH
  return resArr[0];
}

console.log(longestWord("fun&!! time"));
console.log(longestWord("I love dogs"));