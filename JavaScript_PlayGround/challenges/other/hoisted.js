test();
test2();

//OK hoisted
function test(){
    var vartest = 10;
    const constobjtest = {name:'mahmoud',age:42}
    //# id=undefined
    console.log({id:indexVar});
    //#reassigned const property value;
    constobjtest.age = 15; 
    console.log({isChange:true,constobjtest:constobjtest});
    console.log("test() - END");
}

function test2(){
    var vartest2 = 10;
    //#reference error - is not defined 
    //console.log({vartest:vartest});
}

//REFERENCE ERROR
let nextIndex = 3;
//REFERENCE ERROR
const tasks = [1,{name:'mahmoud',age:15}];
//undefined
var indexVar = 10;