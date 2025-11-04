//primitives:number, string, boolean
//# javascript Object types/classes  (Number, String, Boolean)

import { StringLiteral } from "typescript";

//complex types: array, objects
//function types, parameters

//primitives

let age:number;
age= 12;

//#case sensitive
let userName:string;
userName = "Max";

let isMaster:boolean;
isMaster = true;

let noValue:null;
//#Error: non assignable
//noValue= 12;


//complex types

let hobbies :string[];
hobbies = ['Sports','Cooking'];

let person:{
    name:string;
    age:number;
};

//assign person
person = {
    name:'Max',
    age:32
};

//ERROR: not contain boolean structure
//person = {isEmployee: true};

let people:{name:string, age:number}[];

//#type inference, without use colon or detected type ':string'
let course = "this course";
//#Error: not assignable string to number
//course = 1122;

//#union types, to give flexibility
let lesson : string | number = "lesson one";
lesson = 12354; //OK

//#type aliase, using 'type' keyword in TypeScript and not exist in JS
type Car ={
engine:number,
body:string
};

let carObj:Car={engine:1400,body:"SUV"};
let cars:Car[]=[];

//#functions
//function add(a:number, b:number):number{
function add(a:number, b:number){
    return a+b;
}


//function print(value:any):void{
function print(value:any){
    console.log(value);
}



//#Generics type '<T>' instead 'Any'
function insertAtBeginning<T>(array:T[], value:T){
    const newArray = [value, ...array];
    return newArray;
}
//#work with both number or string
const arrayNumber = insertAtBeginning([1,2,3,4,5],-1);
const arrayString = insertAtBeginning(['a','b','c'],'x');
//#ERROR split not exist on type number
//arrayNumber[0].split();



//#class
class Student{
    // firstName:string;
    // lastName:string;
    // age:number;
    // private courses:string[];
    constructor(
    public firstName:string,
    public lastName:string,
    public age:number,
    private courses:string[]
    ){}

    addCourse(courseName:string){
        this.courses.push(courseName);
    }

    listCourses(){
        return this.courses.slice();
    }
}

const student = new Student('Mahmoud','ahmed',20,['Angular','c#','JavaScript']);
student.addCourse('React');
console.log({courses:student.listCourses()});


//#Interface in typescript like contract without implementation like c#,java

interface Humman{
    firstName:string;
    age:Number;
    greet: () => void;
}

//#will assign as JSON Object
let mahmoud: Humman;
mahmoud={
    firstName:"mahmoud",
    age: 41,
    greet() {
        console.log("Hello!");
    },
};

//#class implement interface
class Instrsuctor implements Humman{
    firstName:string="";
    age:number=12;
    greet(){
        console.log('Hello  I am instructor!!');
    }
}
