function codelandUsernameValidation(str){
    //#rule 1 
    
    if(!str || (str.length < 4 || str.length > 25 ))
        return 'false';

    //#rule 2, first character must be letter and last index not '_'
    //# string.charAt(index) works all browsers than bracket notation '[index]'
    
    
    //let validRegex = /^[a-zA-Z]/;
    let validRegex = /^[a-zA-Z]\w+[a-zA-Z0-9]$/;

    /*
    if(!validRegex.test(str.charAt(0)) || str[str.length-1] === '_')
        return 'false';
    */

    //'match'.match(validRegex)

    //# using regualr expression meet remaining rules for valid username 
   var isValid = validRegex.test(str); 

   if(!isValid)
     return 'false';


    return 'true';

}
console.log(
codelandUsernameValidation('aa_'), //false
codelandUsernameValidation('aadf_gd1614sdf@google.com'),//false
codelandUsernameValidation('aadf_gd1614sdf'),//true
codelandUsernameValidation('_aadf_gd1614sdfaagg'),//false
codelandUsernameValidation('_aadf_gd1614sdfaaggooooooooooooooooooooooooooooooooooo')//false
);
/*

function isFirstCharacterLetter(str) {
  if (!str) {
    return false; // Handle empty or null strings
  }
  const firstChar = str.charAt(0);
  return /[a-zA-Z]/.test(firstChar);
}

// Examples
console.log(isFirstCharacterLetter("Hello")); // true
console.log(isFirstCharacterLetter("123 world")); // false
console.log(isFirstCharacterLetter("!@#")); // false
console.log(isFirstCharacterLetter("")); // false


function CodelandUsernameValidation(str) { 

  // code goes here  
  const valid_reg = /^[A-Za-z]\w+[A-Za-z0-9]$/;
  const valid_length = (str) => str.length >= 4 && str.length <= 25;
  return valid_reg.test(str) && valid_length(str);
}
   
// keep this function call here 
console.log(CodelandUsernameValidation(readline()));

*/