var name = "mahmoud";
var age = 42;
const hasHobbies = true;
let hight = 177;
hight = 180;
//hasHobbies = false;

function summarizeUserData(name,age,hasHobbies){
    return (
        'name is '+
        name +
        ', age is '+
        age+
        ', and the user hasHobbies: '+
        hasHobbies+
        ' Hight is '+
        hight

    );
}

const sumTwoNumbers = (a,b) =>{
    if(a > b)
        console.log('a greater than b');
    return a+b;
}
const addNumberByOne = a => a+1;
const getTotal = () => 1+2;

//person object
const person = {
    name:'Mahmoud',
    age:42,
    greet:()=> console.log(`Hi my name is ${this.name}, my age is ${this.age}`),
    greetFun(){
        console.log(`Hi my name is ${this.name}, my age is ${this.age}`);
    }
};

//Array
const hobbies = ['Sports','Cooking'];
function displayLoopHobbies(){
    console.log(`#displayLoopHobbies`);
    for(let hobby of hobbies){
        console.log(`hobby:${hobby}`);
    }
}
function mapOnHoppies(){
    console.log(`#mapOnHoppies`);
   const newHobbies = hobbies.map( hobby => `hobby:${hobby}`);
   console.log({
    newHobbies:newHobbies,
    hobbies:hobbies
   });
}
function addHobbyObConstHoppies(){
    console.log(`#addHobbyObConstHoppies`);
    //ok
    //because reference types refer to reference address (heap memory) not actual data 
    hobbies.push("swimming");

    //'const' prevent from assign new instance
    //hobbies=['new hobby']; //ERROR
    console.log({hobbies:hobbies});
}

function sliceHobbiesArray(){
    console.log(`#sliceHobbiesArray`);
    //just shallow copy
    const hobbies2 = hobbies.slice();
    hobbies2.push('soccer');
    console.log({hobbies2:hobbies2,hobbies:hobbies});
}

function deepCopyHobbbiesArray(){
    console.log(`#deepCopyHobbbiesArray`);
    const hobbiesCopy = hobbies;
    hobbiesCopy.push("fly");
    console.log({hobbiesCopy:hobbiesCopy, hobbies:hobbies});
}
function spreadOperator(){
    console.log(`#spreadOperator`);
    const hobbiesAoA = [hobbies];
    const hobbiesSpreadCopy = [...hobbies];
    console.log({
        hobbies2ArrayofArray:hobbiesAoA,
        hobbiesSpreadCopy:hobbiesSpreadCopy,
        personSpread:{...person}
    });
}
function restOperator(){
    console.log(`#restOperator`);
    const logArrayNumbers = (...args) => args;
    console.log({args:logArrayNumbers(1,2,3,4,5,6,7,8,9)});
}

function destructingImplementation(){
    console.log(`#destructingImplementation`);
    const {name, age, coco} = person;
    console.log({name:name, age:age, coco:coco});

    const [arr1,arr2] = hobbies;
    console.log({arr1:arr1, arr2:arr2});
}

function asyncCodeImplement(){
    console.log(`#asyncCodeImplement`);

    const fetchdata = callback =>{
        setTimeout(() =>{
            callback("fetchData Done!");
        },1500);        
    };

    setTimeout(()=>{
        console.log("Timer is out");
        fetchdata((text) =>{
            console.log(text);
        });
    },2000);

    console.log("Hi");
    console.log("Hello Mahmoud!");
}

function promiseCreation(){
    const promise = new Promise((resolve,reject)=>{
        setTimeout(()=>{
            resolve("Promise Done!");
        },1500);
    });
    return promise;
}

function promiseImplement(){
    console.log(`#promiseImplement`);
    promiseCreation()
    .then((res1) => {
        console.log(res1);
        return promiseCreation(); // to make chain of multiple promise 'then'
    })
    .then(res2 => {
        console.log(res2);
    });
}

console.log(summarizeUserData(name,age,hasHobbies));
console.log(sumTwoNumbers(6,4));
console.log(addNumberByOne(9));
console.log(getTotal());
person.greet();
person.greetFun();
displayLoopHobbies();
mapOnHoppies();
addHobbyObConstHoppies();
sliceHobbiesArray();
deepCopyHobbbiesArray();
spreadOperator();
restOperator();
destructingImplementation();
//asyncCodeImplement();
promiseImplement();