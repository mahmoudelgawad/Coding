function codelandUsernameValidation(str){
    //#rule 1 
    
    if(!str || (str.length < 4 || str.length > 25 ))
        return 'false';

    //#rule 2, first character must be letter and last index not '_'
    //# string.charAt(index) return empty string if index out of range, works all browsers,
    //# more than bracket notation 'string[index]' that return undefined if index out of range
    
    
    //let validRegex = /^[a-zA-Z]/;
    const validRegex = /^[a-zA-Z]\w+[a-zA-Z0-9]$/;

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