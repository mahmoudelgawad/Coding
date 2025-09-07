export const arrayFunctions = () =>{
    const hobbies = ["Sports","Cooking","Reading"];
    console.log(hobbies[0]);
    console.log(hobbies[0][0]);

    hobbies.push("Working");
    console.log("hobbies",hobbies);

    const index = hobbies.findIndex( item => item.toLowerCase()[0] === 'r');
    console.log("index",index);

    const editedHobbies = hobbies.map(item => item + "!");
    console.log("editedHobbies",editedHobbies);
};
