export const implement = ()=>{
 
    const password = prompt("Your Password");
    if(password==="Hello")
        console.log("Hello works");
    else if(password==="hello")
        console.log("hello works");
    else
        console.log("Access not granted!.");

    const hobbies = ["Cooking","Football"];
    for(let hobby of hobbies){
        console.log(hobby);
    }
}