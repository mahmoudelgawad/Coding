const globalUser = {
    name:"global",
    age:100
};
export const createUserJSON = ()=>{
 const userJSON = {
    name:'Mahmoud',
    age: 37,
    greet(){
      console.log(`Hello! my name ${this.name} age is ${this.age}`);
    }
 };
 userJSON.greet();
};

export const createUserClass = () =>{
    class User{
        constructor(name,age){
            this.name = name;
            this.age = age;
        }
        greet(){
            console.log(`hello! MY name ${this.name}, age ${this.age}`);
            console.log(`will hoist ${globalUser.name} age ${globalUser.age}`);
        }
    }

    const user = new User("Kader",60);
    user.greet();
};