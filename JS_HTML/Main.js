
//named function
function funTestOne(){
    console.log("funTestOne()");
    document.writeln("funTestOne()");
}


function spreadOperator(){
    const obj1 ={prop1:1};
    const obj2 = obj1; //point to same reference
    const obj3={...obj1};
    obj2.prop1=2; //change affect on obj1 reference value
    console.log({obj1:obj1, obj2:obj2, obj3:obj3});
}

function HoistingVar(){
    function fun(){
        console.log({'Top HoistingVar().fun() -> I value':i});
        var arr = [];
        for(var i = 0;i<10;i++){
            arr[i]=function(){return i;}
        }
        console.log({'HoistingVar().fun() -> I value':i});
        return arr;
    }
    // var i not defined here
    // console.log({'HoistingVar() -> I value':i});
    var arr2 = fun();
    console.log({arr2Elm5:arr2[5]()});  
}


function thisKeyWordWithObject(){

    let JSONObj = {
        name:'ebcell',
        func : function(){
            let self = this;
            console.log(this.name);
            console.log(self.name);
    
            /*()() this point to new object*/
            (function(){
                console.log(this.name === "");
                console.log(self.name);
            })();

            /*this point to new object*/
            // let fun = function(){
            //     console.log(this.name);
            //     console.log(self.name);
            // };
            // fun();
        

        /*this point to exist JSONObj object*/
        //    let fun = () =>{
        //          console.log(this.name);
        //         console.log(self.name);
        //     }
        //     fun();

        },
    };

    JSONObj.func();
}

function setTimeOutConsoleOrderCalls(){
    console.log(1);
    setTimeout(() =>{console.log(2)},1000);
    setTimeout(()=>{console.log(3)},0);
    console.log(4);
}

function generatorFunction(){

    function* geneFuncName(i){
        yield i;
        yield i+10;
        yield i+20
    }

    function* geneFuncNameWithReturn(i){
        yield i;
        return i+10;
        yield i+20; // unreachable Code
    }

    const gen = geneFuncName(5);
    console.log({yield1:gen.next().value,
                yield2:gen.next().value,
                yield3:gen.next().value});

    const genReturn = geneFuncNameWithReturn(5)
    console.log({yield1:genReturn.next(),
        return:genReturn.next(),
        yield2Unreachable:genReturn.next()});


}


function generatorFunctionWithLoop(){

    function* geneFuncName(i){
        yield i;
        yield i+10;
        yield i+20
    }

    const arr=[];
    const arr2=[];

    const gen = geneFuncName(5);
    for(const nextValue of gen){
        arr.push(nextValue);
    }

    for(const nextValue of gen){
        arr2.push(nextValue);//empty value each time because next() iterator is done
    }

    console.log(arr);
    console.log(arr2); // empty array
}


function test(){
    const obj ={
        name:"mahmoud",
        printff(i){console.log(i);},
        age:12
    }
obj.printff(5);
  throw new Error(asasa);
  Object.freeze
}

function hashTable(){
const obj = {key:"a",value:2}
console.log("owned property key:",obj.hasOwnProperty("key"));

const dic = new Map(); //has table in js
dic.set("a",20);
dic.set("b",30);
dic.set("c",40);
console.log("size:",dic.size);
console.log("values:",dic.values());
console.log("keys:",dic.keys());
console.log("get b:",dic.get("b"));
console.log("has key a :",dic.has('a'));
dic.delete('c');
console.log('get deleted c:',dic.get('c')); //undefined
}



////###############  Implementation   ##################
// call named function
//funTestOne();
//arrayMap();
//arrayFilter();
//arraySlice();
//arraySplice();
//spreadOperator();
//HoistingVar();
//thisKeyWordWithObject();
//setTimeOutConsoleOrderCalls();
//generatorFunction();
//generatorFunctionWithLoop();
//test();
//hashTable();
//sortArrayUsers();

