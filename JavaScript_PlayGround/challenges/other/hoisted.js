test();

//OK hoisted
function test(){
    //console.log({id: ++nextIndex, age:tasks[0].age});
    console.log({id:indexVar});
    console.log("just test function");
}

//REFERENCE ERROR
let nextIndex = 3;
//REFERENCE ERROR
const tasks = [1,{name:'mahmoud',age:15}];
//undefined
var indexVar = 10;