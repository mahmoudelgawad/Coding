export const implementSpreadOperator = ()=>{
    const hobbies = ["Sports","Cooking"];
    const newHobbies = ["Reading"];
    //#merge 2 arrays values
    const mergeHobbies = [...hobbies, ...newHobbies];
    console.log({mergeHobbies:mergeHobbies});

    const user = {
        name:"Mahmoud",
        age:"41",
    };

    //#merge/extend with other new object
    const extendedUser = {
        isAdmin:true,
        ...user
    };
    console.log({extendedUser:extendedUser});
}